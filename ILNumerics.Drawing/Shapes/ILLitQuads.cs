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
using System.Runtime.InteropServices;
using System.Text;
using System.Drawing; 
using ILNumerics.Drawing; 
using ILNumerics; 
using ILNumerics.BuiltInFunctions; 
using ILNumerics.Drawing.Graphs; 
using ILNumerics.Exceptions; 
using ILNumerics.Drawing.Controls; 


namespace ILNumerics.Drawing.Shapes {
    
    public class ILLitQuads 
        : ILLitCompositeShape<C4fN3fV3f> {

        #region constructors
        /// <summary>
        /// create composite shape, consisting out of lit quads 
        /// </summary>
        /// <param name="panel">hosting panel</param>
        /// <param name="numVertices">number of vertices needed for all lit quads</param>
        public ILLitQuads (ILPanel panel, int numVertices)
            : base(panel, numVertices, 4) {
            m_fillColor = Color.Green; 
        }
        /// <summary>
        /// create composite shape, consisting out of lit quads 
        /// </summary>
        /// <param name="panel">hosting panel</param>
        /// <param name="X">x coordinates vector</param>
        /// <param name="Y">y coordinates vector</param>
        /// <param name="Z">z coordinates vector</param>
        public ILLitQuads (ILPanel panel, ILBaseArray X, ILBaseArray Y, ILBaseArray Z) 
            : base (panel,4,X,Y,Z) { 
            m_fillColor = Color.Green;  
        }
        /// <summary>
        /// create composite shape, consisting out of lit quads 
        /// </summary>
        /// <param name="panel">hosting panel</param>
        /// <param name="X">x coordinates vector</param>
        /// <param name="Y">y coordinates vector</param>
        /// <param name="Z">z coordinates vector</param>
        /// <param name="mapping">Mapping of shapes, composes quads out of vertices. Matrix having 4 rows.
        /// Every element in a column specifies the index of a vertex according to its position in X,Y,Z.
        /// The 4 elements in a column therefore compose a single quad. Vertices may get used arbitrary 
        /// times (or not at all). All elements must be positive integer values in range 
        /// 0...[<see cref="ILNumerics.Drawing.Shapes.ILShape.VertexCount"/>-1].</param>
        public ILLitQuads (ILPanel panel, ILBaseArray X, ILBaseArray Y, ILBaseArray Z, ILBaseArray mapping) 
            : base (panel,4,X,Y,Z,mapping) {
            m_fillColor = Color.Green;
        }
        /// <summary>
        /// create lit quads, flat shading
        /// </summary>
        /// <param name="panel">hosting panel</param>
        /// <param name="X">x coordinates (true world coords), vector with [vertCount] values</param>
        /// <param name="Y">y coordinates (true world coords), vector with [vertCount] values</param>
        /// <param name="Z">z coordinates (true world coords), vector with [vertCount] values</param>
        /// <param name="color">Color to fill all quads with.</param>
        /// <param name="mapping">Mapping of shapes, composes quads out of vertices. Matrix having 4 rows.
        /// Every element in a column specifies the index of a vertex according to its position in X,Y,Z.
        /// The 4 elements in a column therefore compose a single quad. Vertices may get used arbitrary 
        /// times (or not at all). All elements must be positive integer values in range 
        /// 0...[<see cref="ILNumerics.Drawing.Shapes.ILShape.VertexCount"/>-1].</param>
        public ILLitQuads (ILPanel panel, ILBaseArray X, ILBaseArray Y, ILBaseArray Z, Color color, ILBaseArray mapping) 
            : base (panel,4,X,Y,Z,mapping) {
            m_fillColor = color;
        }
        /// <summary>
        /// create lit quads, interpolated shading
        /// </summary>
        /// <param name="panel">hosting panel</param>
        /// <param name="X">x coordinates (true world coords), vector with [vertCount] values</param>
        /// <param name="Y">y coordinates (true world coords), vector with [vertCount] values</param>
        /// <param name="Z">z coordinates (true world coords), vector with [vertCount] values</param>
        /// <param name="colors">matrix with <see cref="ILNumerics.Drawing.Shapes.ILShape.VertexCount"/> 
        /// rows, 3 columns for (R,G,B) or 4 columns for 
        /// (A,R,G,B) for every vertex specified by X,Y,Z. Elements must range from 0..255. If colors 
        /// has 3 columns only, alpha values of 255 are used as default.</param>
        /// <param name="mapping">Mapping of shapes, composes quads out of vertices. Matrix having 4 rows.
        /// Every element in a column specifies the index of a vertex according to its position in X,Y,Z.
        /// The 4 elements in a column therefore compose a single quad. Vertices may get used arbitrary 
        /// times (or not at all). All elements must be positive integer values in range 
        /// 0...[<see cref="ILNumerics.Drawing.Shapes.ILShape.VertexCount"/>-1].</param>
        public ILLitQuads (ILPanel panel, ILBaseArray X, ILBaseArray Y, ILBaseArray Z, ILBaseArray colors, ILBaseArray mapping) 
            : base (panel,4,X,Y,Z,colors,mapping) {
            m_fillColor = Color.Green;
        }
        #endregion

    }
}
