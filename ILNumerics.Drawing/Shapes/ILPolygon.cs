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
using ILNumerics.Drawing; 
using ILNumerics.Drawing.Controls; 
using ILNumerics.Drawing.Misc;
using ILNumerics.Drawing.Graphs;  
using ILNumerics.Drawing.Interfaces; 
using ILNumerics.Drawing.Shapes; 

namespace ILNumerics.Drawing.Shapes {
    /// <summary>
    /// A simple polygon, rendering arbitrary number of corners, bordered
    /// </summary>
    public class ILPolygon : ILBorderedShape<C4bV3f> {

        #region constructors
        public ILPolygon (ILPanel panel, int numVertices) 
            : base (panel,numVertices) { 
            
        }
        #endregion
        
        /// <summary>
        /// update vertices, may also alter number of edges 
        /// </summary>
        /// <param name="X">X coordinates</param>                   
        /// <param name="Y">Y coordinates</param>
        /// <param name="Z">Z coordinates</param>
        public override void Update(ILBaseArray X, ILBaseArray Y, ILBaseArray Z) {
            int newLen = Math.Max(Math.Max(X.Length,Y.Length),Z.Length);
            if (VertexCount != newLen) {
                m_numVerticesPerShape = newLen; 
                Resize(newLen); 
            }
            base.Update(X, Y, Z);
        }

    }
}
