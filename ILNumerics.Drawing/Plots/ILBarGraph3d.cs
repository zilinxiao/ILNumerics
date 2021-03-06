#region Copyright GPLv3
//
//  This file is part of ILNumerics.Net. 
//
//  ILNumerics.Net supports numeric application development for .NET 
//  Copyright (C) 2007, H. Kutschbach, http://ilnumerics.net 
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//   along with this program.  If not, see <http://www.gnu.org/licenses/>.
// 
//  Non-free licenses are also available. Contact info@ilnumerics.net 
//  for details.
//
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing; 
using ILNumerics.Drawing.Shapes;
using ILNumerics.Drawing;
using ILNumerics.Drawing.Controls;
using ILNumerics.Drawing.Graphs;
using ILNumerics.Exceptions;
using ILNumerics.Drawing.Misc;
using ILNumerics.Drawing.Interfaces; 

namespace ILNumerics.Drawing.Plots {
    
    /// <summary>
    /// Simple 3D Bar Graph - plot
    /// </summary>
    public class ILBarGraph3D : ILPlot, IILPanelConfigurator {

        #region attributes
        ILLitBox3D[,] m_boxes;
        float m_barLengthX = 1.0f;
        float m_barLengthY = 1.0f;
        float m_paddingX = 0.3f;
        float m_paddingY = 0.4f;
        Color m_barColor = Color.FromArgb(170, 210, 210, 255); 
        Color m_barColorGradient = Color.FromArgb(170, 180, 180, 255);
        #endregion

        /// <summary>
        /// create a new 3D Bar Graph plot, provide data matrix
        /// </summary>
        /// <param name="panel">panel hosting the scene</param>
        /// <param name="data">data matrix, at least 2x2 entries</param>
        public ILBarGraph3D(ILPanel panel, ILBaseArray data) 
        : base(panel) {
            if (data == null)
                throw new ILArgumentException("data argument must not be null!");
            create(data, Colormaps.ILNumerics); 
        }
        /// <summary>
        /// get/set opacity of the bars
        /// </summary>
        public byte Opacity {
            set {
                foreach (ILLitBox3D box in m_boxes) {
                    box.Opacity = value; 
                }
            }
        }
        /// <summary>
        /// individual access to each bar (ILLitBox) 
        /// </summary>
        /// <param name="row">row index, 0 based</param>
        /// <param name="col">column index, 0 based</param>
        /// <returns>lit box shape at specified position</returns>
        public ILLitBox3D this[int row, int col] {
            get { 
                return m_boxes[row,col];   
            }
        }

        #region public interface
        /// <summary>
        /// set axes labels and tick labels at once
        /// </summary>
        /// <param name="panel">panel hosting the plot</param>
        /// <param name="xlabel">label text for x axis</param>
        /// <param name="ylabel">label text for y axis</param>
        /// <param name="zlabel">label text for z axis</param>
        /// <param name="xtickLabels">collection of strings for columns labels (x-direction)</param>
        /// <param name="ytickLabels">collection of strings for row labels (x-direction)</param>
        public void SetLabels(ILPanel panel
                                , string xlabel, string ylabel, string zlabel
                                , ICollection<string> xtickLabels
                                , ICollection<string> ytickLabels
                                ) {
            panel.Axes[0].LabeledTicks.Clear();
            int counter = 0;
            if (xtickLabels != null)
                foreach (string s in xtickLabels) {
                    panel.Axes[0].LabeledTicks.Add(m_boxes[0, counter].Center.X, s);
                    counter++;
                }
            panel.Axes[1].LabeledTicks.Clear();
            counter = 0;
            if (ytickLabels != null)
                foreach (string s in ytickLabels) {
                    panel.Axes[1].LabeledTicks.Add(m_boxes[counter, 0].Center.Y, s);
                    counter++;
                }
            panel.Axes[0].Label.Text = xlabel;
            panel.Axes[1].Label.Text = ylabel;
            panel.Axes[2].Label.Text = zlabel;

        }

        #endregion

        #region private helper
        private void create(ILBaseArray data, Colormaps colormap) {
            ILArray<float> dataF = ILNumerics.BuiltInFunctions.ILMath.tosingle(data); 
            m_boxes = new ILLitBox3D[data.Dimensions[0],data.Dimensions[1]];
            float maxY = data.Dimensions[0] * (m_barLengthY + m_paddingY);
            // prepare coloring for top quads 
            ILColormap cmap = new ILColormap(colormap); 
            float minV,maxV,mult;
            dataF.GetLimits(out minV, out maxV);
            if (maxV > minV) {
                mult = (cmap.Length - 1) / (maxV - minV);
            } else {
                minV = 0; 
                mult = 0;
            }
            for (int r = 0; r < data.Dimensions[0]; r++) {
                for (int c = 0; c < data.Dimensions[1]; c++) {
                    float val = dataF.GetValue(r, c);  
                    ILPoint3Df max = new ILPoint3Df(
                        (float)(c * (m_paddingX + m_barLengthX) + m_barLengthX)
                        , (float)(maxY - r * (m_paddingY + m_barLengthY))
                        , val);
                    ILPoint3Df min = new ILPoint3Df(
                        max.X - m_barLengthX
                        , max.Y - m_barLengthY
                        , 0);
                    Color topColor = cmap.Map((double)(val - minV) * mult); 
                    ILLitBox3D box = new ILLitBox3D(m_panel,min,max,m_barColor,topColor);
                    box.GradientColor = m_barColorGradient;
                    box.TopLabel.Color = topColor;
                    box.TopLabel.Text = ""; 
                    m_boxes[r, c] = box; 
                    Add(box); 
                }
            }
        }
        #endregion


        #region IILPanelConfigurator Members
        /// <summary>
        /// configure default view of panel, called when adding the plot to the panel
        /// </summary>
        /// <param name="panel">panel hosting the plot</param>
        public void ConfigurePanel(ILPanel panel) {
            panel.BackgroundFilled = false;
            panel.ClipViewData = false;
            panel.Axes.LinesVisible = false;
            panel.Projection = Projection.Perspective;
            panel.DefaultView.SetDeg(-35, 55, 250);

            // configure light
            panel.Lights[0].Enabled = true;
            panel.Lights[0].Position = new ILPoint3Df(0, 0, 250);

            panel.BackgroundFilled = false;
            panel.BackColor = Color.White;
            panel.Axes.GridVisible = false;
            panel.Axes.LinesVisible = false;
            // configure X axis
            panel.Axes[0].LabeledTicks.Mode = TickMode.Manual;
            panel.Axes[0].LabeledTicks.Color = Color.Black;
            panel.Axes[0].LabeledTicks.Clear(); 

            panel.Axes[1].NearLines.Visible = false;
            panel.Axes[1].FarLines.Visible = false;
            panel.Axes[1].Label.Color = Color.Black;

            panel.Axes[2].NearLines.Visible = false;
            panel.Axes[2].FarLines.Visible = false;
            panel.Axes[2].Grid.Visible = true;
            panel.Axes[2].Grid.Color = Color.DarkGray;
            panel.Axes[2].Grid.Antialiasing = true;

            panel.Axes[2].Label.Color = Color.Black;

            panel.Axes[2].LabeledTicks.Color = Color.Black;
            panel.Axes[0].NearLines.Visible = false;
            panel.Axes[0].FarLines.Visible = false;
            panel.Axes[0].Label.Color = Color.Black;

            // configure Y axis
            panel.Axes[1].LabeledTicks.Mode = TickMode.Manual;
            panel.Axes[1].LabeledTicks.Color = Color.Black;
        }

        #endregion
    }
}
