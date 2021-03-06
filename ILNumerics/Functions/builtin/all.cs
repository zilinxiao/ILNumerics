//////////////////////////////////////////////////////////////////
//                                                              //
//  This is an auto - manipulated source file.                  //
//  Edits inside regions of HYCALPER AUTO GENERATED CODE        //
//  will be lost and overwritten on the next build!             //
//                                                              //
//////////////////////////////////////////////////////////////////
#region LGPL License
/*    
    This file is part of ILNumerics.Net Core Module.

    ILNumerics.Net Core Module is free software: you can redistribute it 
    and/or modify it under the terms of the GNU Lesser General Public 
    License as published by the Free Software Foundation, either version 3
    of the License, or (at your option) any later version.

    ILNumerics.Net Core Module is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Lesser General Public License for more details.

    You should have received a copy of the GNU Lesser General Public License
    along with ILNumerics.Net Core Module.  
    If not, see <http://www.gnu.org/licenses/>.
*/
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using ILNumerics.Storage;
using ILNumerics.Misc;
using ILNumerics.Exceptions; 
       
namespace ILNumerics.BuiltInFunctions  {
    public partial class ILMath {
        #region HYCALPER LOOPSTART UNARY_ACCU_TEMPLATE1@Functions\builtin\Sum.cs
/*!HC:TYPELIST:
<hycalper>
<type>
    <source>
        inCls1
    </source>
    <destination><![CDATA[ILArray<complex>]]></destination>
    <destination><![CDATA[ILArray<float>]]></destination>
    <destination><![CDATA[ILArray<fcomplex>]]></destination>
    <destination><![CDATA[ILArray<byte>]]></destination>
    <destination><![CDATA[ILArray<char>]]></destination>
    <destination><![CDATA[ILArray<Int16>]]></destination>
    <destination><![CDATA[ILArray<Int32>]]></destination>
    <destination><![CDATA[ILArray<Int64>]]></destination>
    <destination><![CDATA[ILArray<UInt16>]]></destination>
    <destination><![CDATA[ILArray<UInt32>]]></destination>
    <destination><![CDATA[ILArray<UInt64>]]></destination>
    <destination><![CDATA[ILArray<double>]]></destination>
</type>
<type>
    <source>
        outCls1
    </source>
    <destination><![CDATA[ILLogicalArray]]></destination>
    <destination><![CDATA[ILLogicalArray]]></destination>
    <destination><![CDATA[ILLogicalArray]]></destination>
    <destination><![CDATA[ILLogicalArray]]></destination>
    <destination><![CDATA[ILLogicalArray]]></destination>
    <destination><![CDATA[ILLogicalArray]]></destination>
    <destination><![CDATA[ILLogicalArray]]></destination>
    <destination><![CDATA[ILLogicalArray]]></destination>
    <destination><![CDATA[ILLogicalArray]]></destination>
    <destination><![CDATA[ILLogicalArray]]></destination>
    <destination><![CDATA[ILLogicalArray]]></destination>
    <destination><![CDATA[ILLogicalArray]]></destination>
</type>
<type>
    <source>
        funcname
    </source>
    <destination>all</destination>
    <destination>all</destination>
    <destination>all</destination>
    <destination>all</destination>
    <destination>all</destination>
    <destination>all</destination>
    <destination>all</destination>
    <destination>all</destination>
    <destination>all</destination>
    <destination>all</destination>
    <destination>all</destination>
    <destination>all</destination>
</type>
<type>
    <source locate="comment">
        summary
    </source>
    <destination>determine, if all elements are nonzero</destination>
    <destination>determine, if all elements are nonzero</destination>
    <destination>determine, if all elements are nonzero</destination>
    <destination>determine, if all elements are nonzero</destination>
    <destination>determine, if all elements are nonzero</destination>
    <destination>determine, if all elements are nonzero</destination>
    <destination>determine, if all elements are nonzero</destination>
    <destination>determine, if all elements are nonzero</destination>
    <destination>determine, if all elements are nonzero</destination>
    <destination>determine, if all elements are nonzero</destination>
    <destination>determine, if all elements are nonzero</destination>
    <destination>determine, if all elements are nonzero</destination>
</type>
<type>
    <source locate="comment">
        returns
    </source>
    <destination><![CDATA[<para>array of same size as A, having the first non singleton dimension reduced to 1, if any elements along that dimension are nonzero, '0' else. </para>]]></destination>
    <destination><![CDATA[<para>array of same size as A, having the first non singleton dimension reduced to 1, if any elements along that dimension are nonzero, '0' else. </para>]]></destination>
    <destination><![CDATA[<para>array of same size as A, having the first non singleton dimension reduced to 1, if all elements along that dimension are nonzero, '0' else. </para>]]></destination>
    <destination><![CDATA[<para>array of same size as A, having the first non singleton dimension reduced to 1, if all elements along that dimension are nonzero, '0' else. </para>]]></destination>
    <destination><![CDATA[<para>array of same size as A, having the first non singleton dimension reduced to 1, if all elements along that dimension are nonzero, '0' else. </para>]]></destination>
    <destination><![CDATA[<para>array of same size as A, having the first non singleton dimension reduced to 1, if all elements along that dimension are nonzero, '0' else. </para>]]></destination>
    <destination><![CDATA[<para>array of same size as A, having the first non singleton dimension reduced to 1, if all elements along that dimension are nonzero, '0' else. </para>]]></destination>
    <destination><![CDATA[<para>array of same size as A, having the first non singleton dimension reduced to 1, if all elements along that dimension are nonzero, '0' else. </para>]]></destination>
    <destination><![CDATA[<para>array of same size as A, having the first non singleton dimension reduced to 1, if all elements along that dimension are nonzero, '0' else. </para>]]></destination>
    <destination><![CDATA[<para>array of same size as A, having the first non singleton dimension reduced to 1, if all elements along that dimension are nonzero, '0' else. </para>]]></destination>
    <destination><![CDATA[<para>array of same size as A, having the first non singleton dimension reduced to 1, if all elements along that dimension are nonzero, '0' else. </para>]]></destination>
    <destination><![CDATA[<para>array of same size as A, having the first non singleton dimension reduced to 1, if all elements along that dimension are nonzero, '0' else. </para>]]></destination>
</type>
</hycalper>
*/

        #endregion HYCALPER LOOPEND UNARY_ACCU_TEMPLATE1@Sum.cs
#region HYCALPER AUTO GENERATED CODE
// DO NOT EDIT INSIDE THIS REGION !! CHANGES WILL BE LOST !! 
        /// <summary>determine, if all elements are nonzero</summary>
        /// <param name="A">n-dimensional array</param>
        /// <returns><para>array of same size as A, having the first non singleton dimension reduced to 1, if all elements along that dimension are nonzero, '0' else. </para></returns>
		public static  ILLogicalArray  all ( ILArray<double> A) {
            return  all (A, A.Dimensions.FirstNonSingleton());
        }
        /// <summary>determine, if all elements are nonzero</summary>
        /// <param name="A">n-dimensional array</param>
        /// <returns><para>array of same size as A, having the first non singleton dimension reduced to 1, if all elements along that dimension are nonzero, '0' else. </para></returns>
		public static  ILLogicalArray  all ( ILArray<UInt64> A) {
            return  all (A, A.Dimensions.FirstNonSingleton());
        }
        /// <summary>determine, if all elements are nonzero</summary>
        /// <param name="A">n-dimensional array</param>
        /// <returns><para>array of same size as A, having the first non singleton dimension reduced to 1, if all elements along that dimension are nonzero, '0' else. </para></returns>
		public static  ILLogicalArray  all ( ILArray<UInt32> A) {
            return  all (A, A.Dimensions.FirstNonSingleton());
        }
        /// <summary>determine, if all elements are nonzero</summary>
        /// <param name="A">n-dimensional array</param>
        /// <returns><para>array of same size as A, having the first non singleton dimension reduced to 1, if all elements along that dimension are nonzero, '0' else. </para></returns>
		public static  ILLogicalArray  all ( ILArray<UInt16> A) {
            return  all (A, A.Dimensions.FirstNonSingleton());
        }
        /// <summary>determine, if all elements are nonzero</summary>
        /// <param name="A">n-dimensional array</param>
        /// <returns><para>array of same size as A, having the first non singleton dimension reduced to 1, if all elements along that dimension are nonzero, '0' else. </para></returns>
		public static  ILLogicalArray  all ( ILArray<Int64> A) {
            return  all (A, A.Dimensions.FirstNonSingleton());
        }
        /// <summary>determine, if all elements are nonzero</summary>
        /// <param name="A">n-dimensional array</param>
        /// <returns><para>array of same size as A, having the first non singleton dimension reduced to 1, if all elements along that dimension are nonzero, '0' else. </para></returns>
		public static  ILLogicalArray  all ( ILArray<Int32> A) {
            return  all (A, A.Dimensions.FirstNonSingleton());
        }
        /// <summary>determine, if all elements are nonzero</summary>
        /// <param name="A">n-dimensional array</param>
        /// <returns><para>array of same size as A, having the first non singleton dimension reduced to 1, if all elements along that dimension are nonzero, '0' else. </para></returns>
		public static  ILLogicalArray  all ( ILArray<Int16> A) {
            return  all (A, A.Dimensions.FirstNonSingleton());
        }
        /// <summary>determine, if all elements are nonzero</summary>
        /// <param name="A">n-dimensional array</param>
        /// <returns><para>array of same size as A, having the first non singleton dimension reduced to 1, if all elements along that dimension are nonzero, '0' else. </para></returns>
		public static  ILLogicalArray  all ( ILArray<char> A) {
            return  all (A, A.Dimensions.FirstNonSingleton());
        }
        /// <summary>determine, if all elements are nonzero</summary>
        /// <param name="A">n-dimensional array</param>
        /// <returns><para>array of same size as A, having the first non singleton dimension reduced to 1, if all elements along that dimension are nonzero, '0' else. </para></returns>
		public static  ILLogicalArray  all ( ILArray<byte> A) {
            return  all (A, A.Dimensions.FirstNonSingleton());
        }
        /// <summary>determine, if all elements are nonzero</summary>
        /// <param name="A">n-dimensional array</param>
        /// <returns><para>array of same size as A, having the first non singleton dimension reduced to 1, if all elements along that dimension are nonzero, '0' else. </para></returns>
		public static  ILLogicalArray  all ( ILArray<fcomplex> A) {
            return  all (A, A.Dimensions.FirstNonSingleton());
        }
        /// <summary>determine, if all elements are nonzero</summary>
        /// <param name="A">n-dimensional array</param>
        /// <returns><para>array of same size as A, having the first non singleton dimension reduced to 1, if any elements along that dimension are nonzero, '0' else. </para></returns>
		public static  ILLogicalArray  all ( ILArray<float> A) {
            return  all (A, A.Dimensions.FirstNonSingleton());
        }
        /// <summary>determine, if all elements are nonzero</summary>
        /// <param name="A">n-dimensional array</param>
        /// <returns><para>array of same size as A, having the first non singleton dimension reduced to 1, if any elements along that dimension are nonzero, '0' else. </para></returns>
		public static  ILLogicalArray  all ( ILArray<complex> A) {
            return  all (A, A.Dimensions.FirstNonSingleton());
        }

#endregion HYCALPER AUTO GENERATED CODE

        #region HYCALPER LOOPSTART UNARY_ACCU_TEMPLATE2@Functions\builtin\Sum.cs
/*!HC:TYPELIST:
<hycalper>
<type>
    <source>
        inCls1
    </source>
    <destination><![CDATA[ILArray<complex>]]></destination>
    <destination><![CDATA[ILArray<float>]]></destination>
    <destination><![CDATA[ILArray<fcomplex>]]></destination>
    <destination><![CDATA[ILArray<byte>]]></destination>
    <destination><![CDATA[ILArray<char>]]></destination>
    <destination><![CDATA[ILArray<Int16>]]></destination>
    <destination><![CDATA[ILArray<Int32>]]></destination>
    <destination><![CDATA[ILArray<Int64>]]></destination>
    <destination><![CDATA[ILArray<UInt16>]]></destination>
    <destination><![CDATA[ILArray<UInt32>]]></destination>
    <destination><![CDATA[ILArray<UInt64>]]></destination>
    <destination><![CDATA[ILArray<double>]]></destination>
</type>
<type>
    <source>
        outCls1
    </source>
    <destination><![CDATA[ILLogicalArray]]></destination>
    <destination><![CDATA[ILLogicalArray]]></destination>
    <destination><![CDATA[ILLogicalArray]]></destination>
    <destination><![CDATA[ILLogicalArray]]></destination>
    <destination><![CDATA[ILLogicalArray]]></destination>
    <destination><![CDATA[ILLogicalArray]]></destination>
    <destination><![CDATA[ILLogicalArray]]></destination>
    <destination><![CDATA[ILLogicalArray]]></destination>
    <destination><![CDATA[ILLogicalArray]]></destination>
    <destination><![CDATA[ILLogicalArray]]></destination>
    <destination><![CDATA[ILLogicalArray]]></destination>
    <destination><![CDATA[ILLogicalArray]]></destination>
</type>
<type>
    <source>
        inArr1
    </source>
    <destination>complex</destination>
    <destination>float</destination>
    <destination>fcomplex</destination>
    <destination>byte</destination>
    <destination>char</destination>
    <destination>Int16</destination>
    <destination>Int32</destination>
    <destination>Int64</destination>
    <destination>UInt16</destination>
    <destination>UInt32</destination>
    <destination>UInt64</destination>
    <destination>double</destination>
</type>
<type>
    <source>
        inArr2
    </source>
    <destination>complex</destination>
    <destination>float</destination>
    <destination>fcomplex</destination>
    <destination>byte</destination>
    <destination>char</destination>
    <destination>Int16</destination>
    <destination>Int32</destination>
    <destination>Int64</destination>
    <destination>UInt16</destination>
    <destination>UInt32</destination>
    <destination>UInt64</destination>
    <destination>double</destination>
</type>
<type>
    <source>
        outArr1
    </source>
    <destination>byte</destination>
    <destination>byte</destination>
    <destination>byte</destination>
    <destination>byte</destination>
    <destination>byte</destination>
    <destination>byte</destination>
    <destination>byte</destination>
    <destination>byte</destination>
    <destination>byte</destination>
    <destination>byte</destination>
    <destination>byte</destination>
    <destination>byte</destination>
</type>
<type>
    <source>
        funcname
    </source>
    <destination>all</destination>
    <destination>all</destination>
    <destination>all</destination>
    <destination>all</destination>
    <destination>all</destination>
    <destination>all</destination>
    <destination>all</destination>
    <destination>all</destination>
    <destination>all</destination>
    <destination>all</destination>
    <destination>all</destination>
    <destination>all</destination>
</type>
<type>
    <source locate="nextline">
        singletonDimOp
    </source>
    <destination>int tmpCount = 0; </destination>
    <destination>int tmpCount = 0; </destination>
    <destination>int tmpCount = 0; </destination>
    <destination>int tmpCount = 0; </destination>
    <destination>int tmpCount = 0; </destination>
    <destination>int tmpCount = 0; </destination>
    <destination>int tmpCount = 0; </destination>
    <destination>int tmpCount = 0; </destination>
    <destination>int tmpCount = 0; </destination>
    <destination>int tmpCount = 0; </destination>
    <destination>int tmpCount = 0; </destination>
    <destination>int tmpCount = 0; </destination>
</type>
<type>
    <source>
        tmpOutStorage 
    </source>
    <destination>tmpCount</destination>
    <destination>tmpCount</destination>
    <destination>tmpCount</destination>
    <destination>tmpCount</destination>
    <destination>tmpCount</destination>
    <destination>tmpCount</destination>
    <destination>tmpCount</destination>
    <destination>tmpCount</destination>
    <destination>tmpCount</destination>
    <destination>tmpCount</destination>
    <destination>tmpCount</destination>
    <destination>tmpCount</destination>
</type>
<type>
    <source>
        preEvalOp
    </source>
    <destination>(</destination>
    <destination>(</destination>
    <destination>(</destination>
    <destination>(</destination>
    <destination>(</destination>
    <destination>(</destination>
    <destination>(</destination>
    <destination>(</destination>
    <destination>(</destination>
    <destination>(</destination>
    <destination>(</destination>
    <destination>(</destination>
</type>
<type>
    <source>
        postEvalOp
    </source>
    <destination>.iszero())?0:1; </destination>
    <destination> == 0.0f)?0:1;</destination>
    <destination>.iszero())?0:1; </destination>
    <destination> == 0)?0:1;</destination>
    <destination> == 0)?0:1;</destination>
    <destination> == 0)?0:1;</destination>
    <destination> == 0)?0:1;</destination>
    <destination> == 0)?0:1;</destination>
    <destination> == 0)?0:1;</destination>
    <destination> == 0)?0:1;</destination>
    <destination> == 0)?0:1;</destination>
    <destination> == 0.0)?0:1;</destination>
</type>
<type>
    <source locate="nextline">
        HCscalarOp
    </source>
    <destination><![CDATA[return new ILLogicalArray (new byte [1]{(A.GetValue(0).iszero())?(byte)0:(byte)1},1,1);]]></destination>
    <destination><![CDATA[return new ILLogicalArray (new byte [1]{(A.GetValue(0) == 0.0f)?(byte)0:(byte)1},1,1);]]></destination>
    <destination><![CDATA[return new ILLogicalArray (new byte [1]{(A.GetValue(0).iszero())?(byte)1:(byte)0},1,1);]]></destination>
    <destination><![CDATA[return new ILLogicalArray (new byte [1]{(A.GetValue(0) == 0)?(byte)0:(byte)1},1,1);]]></destination>
    <destination><![CDATA[return new ILLogicalArray (new byte [1]{(A.GetValue(0) == 0)?(byte)0:(byte)1},1,1);]]></destination>
    <destination><![CDATA[return new ILLogicalArray (new byte [1]{(A.GetValue(0) == 0)?(byte)0:(byte)1},1,1);]]></destination>
    <destination><![CDATA[return new ILLogicalArray (new byte [1]{(A.GetValue(0) == 0)?(byte)0:(byte)1},1,1);]]></destination>
    <destination><![CDATA[return new ILLogicalArray (new byte [1]{(A.GetValue(0) == 0)?(byte)0:(byte)1},1,1);]]></destination>
    <destination><![CDATA[return new ILLogicalArray (new byte [1]{(A.GetValue(0) == 0)?(byte)0:(byte)1},1,1);]]></destination>
    <destination><![CDATA[return new ILLogicalArray (new byte [1]{(A.GetValue(0) == 0)?(byte)0:(byte)1},1,1);]]></destination>
    <destination><![CDATA[return new ILLogicalArray (new byte [1]{(A.GetValue(0) == 0)?(byte)0:(byte)1},1,1);]]></destination>
    <destination><![CDATA[return new ILLogicalArray (new byte [1]{(A.GetValue(0) == 0.0)?(byte)0:(byte)1},1,1);]]></destination>
</type>
<type>
    <source locate="nextline">
        operationResult
    </source>
    <destination>*tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; </destination>
    <destination>*tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; </destination>
    <destination>*tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; </destination>
    <destination>*tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; </destination>
    <destination>*tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; </destination>
    <destination>*tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; </destination>
    <destination>*tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; </destination>
    <destination>*tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; </destination>
    <destination>*tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; </destination>
    <destination>*tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; </destination>
    <destination>*tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; </destination>
    <destination>*tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; </destination>
</type>
<type>
    <source locate="comment">
        summary
    </source>
    <destination>determine, if all elements are nonzero</destination>
    <destination>determine, if all elements are nonzero</destination>
    <destination>determine, if all elements are nonzero</destination>
    <destination>determine, if all elements are nonzero</destination>
    <destination>determine, if all elements are nonzero</destination>
    <destination>determine, if all elements are nonzero</destination>
    <destination>determine, if all elements are nonzero</destination>
    <destination>determine, if all elements are nonzero</destination>
    <destination>determine, if all elements are nonzero</destination>
    <destination>determine, if all elements are nonzero</destination>
    <destination>determine, if all elements are nonzero</destination>
    <destination>determine, if all elements are nonzero</destination>
</type>
<type>
    <source locate="comment">
        returns
    </source>
    <destination><![CDATA[<para>array of same size as A, having 'leadDim's dimension reduced to 1, if any elements along that dimension are nonzero, '0' else. </para>]]></destination>
    <destination><![CDATA[<para>array of same size as A, having 'leadDim's dimension reduced to 1, if any elements along that dimension are nonzero, '0' else. </para>]]></destination>
    <destination><![CDATA[<para>array of same size as A, having 'leadDim's dimension reduced to 1, if all elements along that dimension are nonzero, '0' else. </para>]]></destination>
    <destination><![CDATA[<para>array of same size as A, having 'leadDim's dimension reduced to 1, if all elements along that dimension are nonzero, '0' else. </para>]]></destination>
    <destination><![CDATA[<para>array of same size as A, having 'leadDim's dimension reduced to 1, if all elements along that dimension are nonzero, '0' else. </para>]]></destination>
    <destination><![CDATA[<para>array of same size as A, having 'leadDim's dimension reduced to 1, if all elements along that dimension are nonzero, '0' else. </para>]]></destination>
    <destination><![CDATA[<para>array of same size as A, having 'leadDim's dimension reduced to 1, if all elements along that dimension are nonzero, '0' else. </para>]]></destination>
    <destination><![CDATA[<para>array of same size as A, having 'leadDim's dimension reduced to 1, if all elements along that dimension are nonzero, '0' else. </para>]]></destination>
    <destination><![CDATA[<para>array of same size as A, having 'leadDim's dimension reduced to 1, if all elements along that dimension are nonzero, '0' else. </para>]]></destination>
    <destination><![CDATA[<para>array of same size as A, having 'leadDim's dimension reduced to 1, if all elements along that dimension are nonzero, '0' else. </para>]]></destination>
    <destination><![CDATA[<para>array of same size as A, having 'leadDim's dimension reduced to 1, if all elements along that dimension are nonzero, '0' else. </para>]]></destination>
    <destination><![CDATA[<para>array of same size as A, having 'leadDim's dimension reduced to 1, if all elements along that dimension are nonzero, '0' else. </para>]]></destination>
</type>
<type>
    <source locate="nextline">
        HCzero
    </source>
    <destination></destination>
    <destination></destination>
    <destination></destination>
    <destination></destination>
    <destination></destination>
    <destination></destination>
    <destination></destination>
    <destination></destination>
    <destination></destination>
    <destination></destination>
    <destination></destination>
    <destination></destination>
</type>
</hycalper>
*/

        #endregion HYCALPER LOOPEND UNARY_ACCU_TEMPLATE2@Sum.cs
#region HYCALPER AUTO GENERATED CODE
// DO NOT EDIT INSIDE THIS REGION !! CHANGES WILL BE LOST !! 
        /// <summary>determine, if all elements are nonzero</summary>
		/// <param name="A">N-dimensional array</param>
		/// <param name="leadDim">index of dimension to operate along</param>
		/// <returns><para>array of same size as A, having 'leadDim's dimension reduced to 1, if all elements along that dimension are nonzero, '0' else. </para></returns>
        public static  ILLogicalArray  all ( ILArray<double> A, int leadDim) {
            if (leadDim >= A.Dimensions.NumberOfDimensions)
                throw new ILArgumentException("dimension parameter out of range!");
            if (A.IsEmpty)       
                return  ILLogicalArray .empty(A.Dimensions); 
            if (A.IsScalar) {
                return new ILLogicalArray (new byte [1]{(A.GetValue(0) == 0.0)?(byte)0:(byte)1},1,1);
            }
            ILDimension inDim = A.Dimensions; 
			int[] newDims = inDim.ToIntArray();
            int tmpCount = 0; 
			int newLength;
			 byte [] retDblArr;
			// build ILDimension
			newLength = inDim.NumberOfElements / newDims[leadDim];
			newDims[leadDim] = 1;
			retDblArr = ILMemoryPool.Pool.New< byte >(newLength);
            ILDimension newDimension = new ILDimension(newDims); 
            int incOut = newDimension.SequentialIndexDistance(leadDim); 
            int leadDimLen = inDim[leadDim];
            int posCounter; 
			int nrHigherDims = inDim.NumberOfElements / leadDimLen;
            if (A.IsReference) {
#region Reference storage
				// ========================  REFERENCE double Storage ===========
				if (A.IsMatrix) {
#region Matrix
					////////////////////////////   MATRIX   ///////////////////////
					unsafe {
						ILIndexOffset idxOffset = A.m_indexOffset;
						int secDim = (leadDim + 1) % 2;
						fixed (int* leadDimStart = idxOffset[leadDim],
								secDimStart = idxOffset[secDim]) {
							fixed ( byte * pOutArr = retDblArr)
						    fixed ( double * pInArr = A.m_data) {
								 byte * tmpOut = pOutArr;
								 byte * lastElementOut = tmpOut + retDblArr.Length;
								 double * tmpIn = pInArr;
								int* secDimEnd = secDimStart + idxOffset[secDim].Length - 1;
								int* secDimIdx = secDimStart; 
								int* leadDimIdx = leadDimStart;
								int* leadDimEnd = leadDimStart + leadDimLen - 1;
								// start at first element
								while (secDimIdx <= secDimEnd) {
									tmpIn = pInArr + *secDimIdx++; 
									leadDimIdx = leadDimStart;
                                    
									while (leadDimIdx <= leadDimEnd) {
                                        double inVal = *(tmpIn + *leadDimIdx++); 
                                        /**/
										 tmpCount +=  ( (inVal)   == 0.0)?0:1;
									}
                                    *tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; 
                                    tmpOut++;
								}
							}
						}
					} 
#endregion
				} else {
					/////////////////////////////   ARBITRARY DIMENSIONS //////////
#region arbitrary size
					unsafe {
						ILIndexOffset idxOffset = A.m_indexOffset;
						int[] curPosition = new int[A.Dimensions.NumberOfDimensions];
						fixed (int* leadDimStart = idxOffset[leadDim]) {
							fixed ( byte * pOutArr = retDblArr)
							fixed ( double * pInArr = A.m_data) {
								 byte * tmpOut = pOutArr;
								 byte * lastElementOut = tmpOut + retDblArr.Length - 1;
								 double * tmpIn = pInArr + A.m_indexOffset.Map(0);
								int* leadDimIdx = leadDimStart;
								int* leadDimEnd = leadDimStart + leadDimLen;
								int dimLen = curPosition.Length;
								int d, curD;
								// start at first element
                                posCounter = retDblArr.Length; 
								while (posCounter-->0) {
									leadDimIdx = leadDimStart;
                                    
									while (leadDimIdx < leadDimEnd){
                                        double inVal = *(tmpIn + *leadDimIdx++); 
                                        /**/
										 tmpCount +=  ( (inVal)   == 0.0)?0:1;
                                    *tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; 
                                    }
                                    tmpOut += incOut;
                                    if (tmpOut > lastElementOut)
                                        tmpOut -= (retDblArr.Length - 1);
									// increment higher dimensions 
									d = 1;
									while (d < dimLen) {
										curD = (d + leadDim) % dimLen;
										curPosition[curD]++;
										if (curPosition[curD] < idxOffset[curD].Length) {
											break;
										}
										curPosition[curD] = 0;
										d++;
									}
                                    tmpIn = pInArr + A.m_indexOffset.IndexFromArray(curPosition); 
								}
							}
						}
					}
#endregion
				}
				// ==============================================================
#endregion
			} else {
				// physical -> pointer arithmetic
                if (leadDim == 0) {
#region physical along 1st leading dimension
                    unsafe {
                        fixed ( byte * pOutArr = retDblArr)
                        fixed ( double * pInArr = A.m_data) {
                            double * lastElement;
                            byte * tmpOut = pOutArr;
                            double * tmpIn = pInArr;
                            for (int h = nrHigherDims; h-- > 0; ) {
								lastElement = tmpIn + leadDimLen;
                                
                                while (tmpIn < lastElement) {
                                    double inVal = *(tmpIn++); 
                                    /**/
                                    tmpCount +=  ( (inVal)   == 0.0)?0:1;
                                }
                                *tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; 
                                tmpOut++;
                            }
                        }
					}
#endregion
				} else {
#region physical along abitrary dimension
					// sum along abitrary dimension 
                    unsafe {
                        fixed ( byte * pOutArr = retDblArr)
                        fixed ( double * pInArr = A.m_data) {
                            byte * lastElementOut = newLength + pOutArr -1;
                            int inLength = inDim.NumberOfElements -1; 
                            double * lastElementIn = pInArr + inLength; 
                            int inc = inDim.SequentialIndexDistance(leadDim); 
                            byte * tmpOut = pOutArr;
                            int outLength = newLength - 1;
                            double * leadEnd; 
                            double * tmpIn = pInArr;
                            for (int h = nrHigherDims; h--> 0; ) {
								leadEnd = tmpIn + leadDimLen * inc;
                                
                                while (tmpIn < leadEnd) {
                                    double inVal = *(tmpIn); 
                                    tmpIn += inc; 
                                    /**/
                                    tmpCount +=  ( (inVal)   == 0.0)?0:1;
                                }
                                *tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; 
                                tmpOut  += inc;
                                if (tmpOut > lastElementOut)
                                    tmpOut = pOutArr + ((tmpOut - pOutArr) - outLength);
                                if (tmpIn > lastElementIn)
                                    tmpIn = pInArr + ((tmpIn - pInArr) - inLength); 
                            }
                        }
					}
#endregion
				}
			}
			return new  ILLogicalArray (retDblArr, newDims);;
        }
        /// <summary>determine, if all elements are nonzero</summary>
		/// <param name="A">N-dimensional array</param>
		/// <param name="leadDim">index of dimension to operate along</param>
		/// <returns><para>array of same size as A, having 'leadDim's dimension reduced to 1, if all elements along that dimension are nonzero, '0' else. </para></returns>
        public static  ILLogicalArray  all ( ILArray<UInt64> A, int leadDim) {
            if (leadDim >= A.Dimensions.NumberOfDimensions)
                throw new ILArgumentException("dimension parameter out of range!");
            if (A.IsEmpty)       
                return  ILLogicalArray .empty(A.Dimensions); 
            if (A.IsScalar) {
                return new ILLogicalArray (new byte [1]{(A.GetValue(0) == 0)?(byte)0:(byte)1},1,1);
            }
            ILDimension inDim = A.Dimensions; 
			int[] newDims = inDim.ToIntArray();
            int tmpCount = 0; 
			int newLength;
			 byte [] retDblArr;
			// build ILDimension
			newLength = inDim.NumberOfElements / newDims[leadDim];
			newDims[leadDim] = 1;
			retDblArr = ILMemoryPool.Pool.New< byte >(newLength);
            ILDimension newDimension = new ILDimension(newDims); 
            int incOut = newDimension.SequentialIndexDistance(leadDim); 
            int leadDimLen = inDim[leadDim];
            int posCounter; 
			int nrHigherDims = inDim.NumberOfElements / leadDimLen;
            if (A.IsReference) {
#region Reference storage
				// ========================  REFERENCE double Storage ===========
				if (A.IsMatrix) {
#region Matrix
					////////////////////////////   MATRIX   ///////////////////////
					unsafe {
						ILIndexOffset idxOffset = A.m_indexOffset;
						int secDim = (leadDim + 1) % 2;
						fixed (int* leadDimStart = idxOffset[leadDim],
								secDimStart = idxOffset[secDim]) {
							fixed ( byte * pOutArr = retDblArr)
						    fixed ( UInt64 * pInArr = A.m_data) {
								 byte * tmpOut = pOutArr;
								 byte * lastElementOut = tmpOut + retDblArr.Length;
								 UInt64 * tmpIn = pInArr;
								int* secDimEnd = secDimStart + idxOffset[secDim].Length - 1;
								int* secDimIdx = secDimStart; 
								int* leadDimIdx = leadDimStart;
								int* leadDimEnd = leadDimStart + leadDimLen - 1;
								// start at first element
								while (secDimIdx <= secDimEnd) {
									tmpIn = pInArr + *secDimIdx++; 
									leadDimIdx = leadDimStart;
                                    
									while (leadDimIdx <= leadDimEnd) {
                                        UInt64 inVal = *(tmpIn + *leadDimIdx++); 
                                        /**/
										 tmpCount +=  ( (inVal)   == 0)?0:1;
									}
                                    *tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; 
                                    tmpOut++;
								}
							}
						}
					} 
#endregion
				} else {
					/////////////////////////////   ARBITRARY DIMENSIONS //////////
#region arbitrary size
					unsafe {
						ILIndexOffset idxOffset = A.m_indexOffset;
						int[] curPosition = new int[A.Dimensions.NumberOfDimensions];
						fixed (int* leadDimStart = idxOffset[leadDim]) {
							fixed ( byte * pOutArr = retDblArr)
							fixed ( UInt64 * pInArr = A.m_data) {
								 byte * tmpOut = pOutArr;
								 byte * lastElementOut = tmpOut + retDblArr.Length - 1;
								 UInt64 * tmpIn = pInArr + A.m_indexOffset.Map(0);
								int* leadDimIdx = leadDimStart;
								int* leadDimEnd = leadDimStart + leadDimLen;
								int dimLen = curPosition.Length;
								int d, curD;
								// start at first element
                                posCounter = retDblArr.Length; 
								while (posCounter-->0) {
									leadDimIdx = leadDimStart;
                                    
									while (leadDimIdx < leadDimEnd){
                                        UInt64 inVal = *(tmpIn + *leadDimIdx++); 
                                        /**/
										 tmpCount +=  ( (inVal)   == 0)?0:1;
                                    *tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; 
                                    }
                                    tmpOut += incOut;
                                    if (tmpOut > lastElementOut)
                                        tmpOut -= (retDblArr.Length - 1);
									// increment higher dimensions 
									d = 1;
									while (d < dimLen) {
										curD = (d + leadDim) % dimLen;
										curPosition[curD]++;
										if (curPosition[curD] < idxOffset[curD].Length) {
											break;
										}
										curPosition[curD] = 0;
										d++;
									}
                                    tmpIn = pInArr + A.m_indexOffset.IndexFromArray(curPosition); 
								}
							}
						}
					}
#endregion
				}
				// ==============================================================
#endregion
			} else {
				// physical -> pointer arithmetic
                if (leadDim == 0) {
#region physical along 1st leading dimension
                    unsafe {
                        fixed ( byte * pOutArr = retDblArr)
                        fixed ( UInt64 * pInArr = A.m_data) {
                            UInt64 * lastElement;
                            byte * tmpOut = pOutArr;
                            UInt64 * tmpIn = pInArr;
                            for (int h = nrHigherDims; h-- > 0; ) {
								lastElement = tmpIn + leadDimLen;
                                
                                while (tmpIn < lastElement) {
                                    UInt64 inVal = *(tmpIn++); 
                                    /**/
                                    tmpCount +=  ( (inVal)   == 0)?0:1;
                                }
                                *tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; 
                                tmpOut++;
                            }
                        }
					}
#endregion
				} else {
#region physical along abitrary dimension
					// sum along abitrary dimension 
                    unsafe {
                        fixed ( byte * pOutArr = retDblArr)
                        fixed ( UInt64 * pInArr = A.m_data) {
                            byte * lastElementOut = newLength + pOutArr -1;
                            int inLength = inDim.NumberOfElements -1; 
                            UInt64 * lastElementIn = pInArr + inLength; 
                            int inc = inDim.SequentialIndexDistance(leadDim); 
                            byte * tmpOut = pOutArr;
                            int outLength = newLength - 1;
                            UInt64 * leadEnd; 
                            UInt64 * tmpIn = pInArr;
                            for (int h = nrHigherDims; h--> 0; ) {
								leadEnd = tmpIn + leadDimLen * inc;
                                
                                while (tmpIn < leadEnd) {
                                    UInt64 inVal = *(tmpIn); 
                                    tmpIn += inc; 
                                    /**/
                                    tmpCount +=  ( (inVal)   == 0)?0:1;
                                }
                                *tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; 
                                tmpOut  += inc;
                                if (tmpOut > lastElementOut)
                                    tmpOut = pOutArr + ((tmpOut - pOutArr) - outLength);
                                if (tmpIn > lastElementIn)
                                    tmpIn = pInArr + ((tmpIn - pInArr) - inLength); 
                            }
                        }
					}
#endregion
				}
			}
			return new  ILLogicalArray (retDblArr, newDims);;
        }
        /// <summary>determine, if all elements are nonzero</summary>
		/// <param name="A">N-dimensional array</param>
		/// <param name="leadDim">index of dimension to operate along</param>
		/// <returns><para>array of same size as A, having 'leadDim's dimension reduced to 1, if all elements along that dimension are nonzero, '0' else. </para></returns>
        public static  ILLogicalArray  all ( ILArray<UInt32> A, int leadDim) {
            if (leadDim >= A.Dimensions.NumberOfDimensions)
                throw new ILArgumentException("dimension parameter out of range!");
            if (A.IsEmpty)       
                return  ILLogicalArray .empty(A.Dimensions); 
            if (A.IsScalar) {
                return new ILLogicalArray (new byte [1]{(A.GetValue(0) == 0)?(byte)0:(byte)1},1,1);
            }
            ILDimension inDim = A.Dimensions; 
			int[] newDims = inDim.ToIntArray();
            int tmpCount = 0; 
			int newLength;
			 byte [] retDblArr;
			// build ILDimension
			newLength = inDim.NumberOfElements / newDims[leadDim];
			newDims[leadDim] = 1;
			retDblArr = ILMemoryPool.Pool.New< byte >(newLength);
            ILDimension newDimension = new ILDimension(newDims); 
            int incOut = newDimension.SequentialIndexDistance(leadDim); 
            int leadDimLen = inDim[leadDim];
            int posCounter; 
			int nrHigherDims = inDim.NumberOfElements / leadDimLen;
            if (A.IsReference) {
#region Reference storage
				// ========================  REFERENCE double Storage ===========
				if (A.IsMatrix) {
#region Matrix
					////////////////////////////   MATRIX   ///////////////////////
					unsafe {
						ILIndexOffset idxOffset = A.m_indexOffset;
						int secDim = (leadDim + 1) % 2;
						fixed (int* leadDimStart = idxOffset[leadDim],
								secDimStart = idxOffset[secDim]) {
							fixed ( byte * pOutArr = retDblArr)
						    fixed ( UInt32 * pInArr = A.m_data) {
								 byte * tmpOut = pOutArr;
								 byte * lastElementOut = tmpOut + retDblArr.Length;
								 UInt32 * tmpIn = pInArr;
								int* secDimEnd = secDimStart + idxOffset[secDim].Length - 1;
								int* secDimIdx = secDimStart; 
								int* leadDimIdx = leadDimStart;
								int* leadDimEnd = leadDimStart + leadDimLen - 1;
								// start at first element
								while (secDimIdx <= secDimEnd) {
									tmpIn = pInArr + *secDimIdx++; 
									leadDimIdx = leadDimStart;
                                    
									while (leadDimIdx <= leadDimEnd) {
                                        UInt32 inVal = *(tmpIn + *leadDimIdx++); 
                                        /**/
										 tmpCount +=  ( (inVal)   == 0)?0:1;
									}
                                    *tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; 
                                    tmpOut++;
								}
							}
						}
					} 
#endregion
				} else {
					/////////////////////////////   ARBITRARY DIMENSIONS //////////
#region arbitrary size
					unsafe {
						ILIndexOffset idxOffset = A.m_indexOffset;
						int[] curPosition = new int[A.Dimensions.NumberOfDimensions];
						fixed (int* leadDimStart = idxOffset[leadDim]) {
							fixed ( byte * pOutArr = retDblArr)
							fixed ( UInt32 * pInArr = A.m_data) {
								 byte * tmpOut = pOutArr;
								 byte * lastElementOut = tmpOut + retDblArr.Length - 1;
								 UInt32 * tmpIn = pInArr + A.m_indexOffset.Map(0);
								int* leadDimIdx = leadDimStart;
								int* leadDimEnd = leadDimStart + leadDimLen;
								int dimLen = curPosition.Length;
								int d, curD;
								// start at first element
                                posCounter = retDblArr.Length; 
								while (posCounter-->0) {
									leadDimIdx = leadDimStart;
                                    
									while (leadDimIdx < leadDimEnd){
                                        UInt32 inVal = *(tmpIn + *leadDimIdx++); 
                                        /**/
										 tmpCount +=  ( (inVal)   == 0)?0:1;
                                    *tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; 
                                    }
                                    tmpOut += incOut;
                                    if (tmpOut > lastElementOut)
                                        tmpOut -= (retDblArr.Length - 1);
									// increment higher dimensions 
									d = 1;
									while (d < dimLen) {
										curD = (d + leadDim) % dimLen;
										curPosition[curD]++;
										if (curPosition[curD] < idxOffset[curD].Length) {
											break;
										}
										curPosition[curD] = 0;
										d++;
									}
                                    tmpIn = pInArr + A.m_indexOffset.IndexFromArray(curPosition); 
								}
							}
						}
					}
#endregion
				}
				// ==============================================================
#endregion
			} else {
				// physical -> pointer arithmetic
                if (leadDim == 0) {
#region physical along 1st leading dimension
                    unsafe {
                        fixed ( byte * pOutArr = retDblArr)
                        fixed ( UInt32 * pInArr = A.m_data) {
                            UInt32 * lastElement;
                            byte * tmpOut = pOutArr;
                            UInt32 * tmpIn = pInArr;
                            for (int h = nrHigherDims; h-- > 0; ) {
								lastElement = tmpIn + leadDimLen;
                                
                                while (tmpIn < lastElement) {
                                    UInt32 inVal = *(tmpIn++); 
                                    /**/
                                    tmpCount +=  ( (inVal)   == 0)?0:1;
                                }
                                *tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; 
                                tmpOut++;
                            }
                        }
					}
#endregion
				} else {
#region physical along abitrary dimension
					// sum along abitrary dimension 
                    unsafe {
                        fixed ( byte * pOutArr = retDblArr)
                        fixed ( UInt32 * pInArr = A.m_data) {
                            byte * lastElementOut = newLength + pOutArr -1;
                            int inLength = inDim.NumberOfElements -1; 
                            UInt32 * lastElementIn = pInArr + inLength; 
                            int inc = inDim.SequentialIndexDistance(leadDim); 
                            byte * tmpOut = pOutArr;
                            int outLength = newLength - 1;
                            UInt32 * leadEnd; 
                            UInt32 * tmpIn = pInArr;
                            for (int h = nrHigherDims; h--> 0; ) {
								leadEnd = tmpIn + leadDimLen * inc;
                                
                                while (tmpIn < leadEnd) {
                                    UInt32 inVal = *(tmpIn); 
                                    tmpIn += inc; 
                                    /**/
                                    tmpCount +=  ( (inVal)   == 0)?0:1;
                                }
                                *tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; 
                                tmpOut  += inc;
                                if (tmpOut > lastElementOut)
                                    tmpOut = pOutArr + ((tmpOut - pOutArr) - outLength);
                                if (tmpIn > lastElementIn)
                                    tmpIn = pInArr + ((tmpIn - pInArr) - inLength); 
                            }
                        }
					}
#endregion
				}
			}
			return new  ILLogicalArray (retDblArr, newDims);;
        }
        /// <summary>determine, if all elements are nonzero</summary>
		/// <param name="A">N-dimensional array</param>
		/// <param name="leadDim">index of dimension to operate along</param>
		/// <returns><para>array of same size as A, having 'leadDim's dimension reduced to 1, if all elements along that dimension are nonzero, '0' else. </para></returns>
        public static  ILLogicalArray  all ( ILArray<UInt16> A, int leadDim) {
            if (leadDim >= A.Dimensions.NumberOfDimensions)
                throw new ILArgumentException("dimension parameter out of range!");
            if (A.IsEmpty)       
                return  ILLogicalArray .empty(A.Dimensions); 
            if (A.IsScalar) {
                return new ILLogicalArray (new byte [1]{(A.GetValue(0) == 0)?(byte)0:(byte)1},1,1);
            }
            ILDimension inDim = A.Dimensions; 
			int[] newDims = inDim.ToIntArray();
            int tmpCount = 0; 
			int newLength;
			 byte [] retDblArr;
			// build ILDimension
			newLength = inDim.NumberOfElements / newDims[leadDim];
			newDims[leadDim] = 1;
			retDblArr = ILMemoryPool.Pool.New< byte >(newLength);
            ILDimension newDimension = new ILDimension(newDims); 
            int incOut = newDimension.SequentialIndexDistance(leadDim); 
            int leadDimLen = inDim[leadDim];
            int posCounter; 
			int nrHigherDims = inDim.NumberOfElements / leadDimLen;
            if (A.IsReference) {
#region Reference storage
				// ========================  REFERENCE double Storage ===========
				if (A.IsMatrix) {
#region Matrix
					////////////////////////////   MATRIX   ///////////////////////
					unsafe {
						ILIndexOffset idxOffset = A.m_indexOffset;
						int secDim = (leadDim + 1) % 2;
						fixed (int* leadDimStart = idxOffset[leadDim],
								secDimStart = idxOffset[secDim]) {
							fixed ( byte * pOutArr = retDblArr)
						    fixed ( UInt16 * pInArr = A.m_data) {
								 byte * tmpOut = pOutArr;
								 byte * lastElementOut = tmpOut + retDblArr.Length;
								 UInt16 * tmpIn = pInArr;
								int* secDimEnd = secDimStart + idxOffset[secDim].Length - 1;
								int* secDimIdx = secDimStart; 
								int* leadDimIdx = leadDimStart;
								int* leadDimEnd = leadDimStart + leadDimLen - 1;
								// start at first element
								while (secDimIdx <= secDimEnd) {
									tmpIn = pInArr + *secDimIdx++; 
									leadDimIdx = leadDimStart;
                                    
									while (leadDimIdx <= leadDimEnd) {
                                        UInt16 inVal = *(tmpIn + *leadDimIdx++); 
                                        /**/
										 tmpCount +=  ( (inVal)   == 0)?0:1;
									}
                                    *tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; 
                                    tmpOut++;
								}
							}
						}
					} 
#endregion
				} else {
					/////////////////////////////   ARBITRARY DIMENSIONS //////////
#region arbitrary size
					unsafe {
						ILIndexOffset idxOffset = A.m_indexOffset;
						int[] curPosition = new int[A.Dimensions.NumberOfDimensions];
						fixed (int* leadDimStart = idxOffset[leadDim]) {
							fixed ( byte * pOutArr = retDblArr)
							fixed ( UInt16 * pInArr = A.m_data) {
								 byte * tmpOut = pOutArr;
								 byte * lastElementOut = tmpOut + retDblArr.Length - 1;
								 UInt16 * tmpIn = pInArr + A.m_indexOffset.Map(0);
								int* leadDimIdx = leadDimStart;
								int* leadDimEnd = leadDimStart + leadDimLen;
								int dimLen = curPosition.Length;
								int d, curD;
								// start at first element
                                posCounter = retDblArr.Length; 
								while (posCounter-->0) {
									leadDimIdx = leadDimStart;
                                    
									while (leadDimIdx < leadDimEnd){
                                        UInt16 inVal = *(tmpIn + *leadDimIdx++); 
                                        /**/
										 tmpCount +=  ( (inVal)   == 0)?0:1;
                                    *tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; 
                                    }
                                    tmpOut += incOut;
                                    if (tmpOut > lastElementOut)
                                        tmpOut -= (retDblArr.Length - 1);
									// increment higher dimensions 
									d = 1;
									while (d < dimLen) {
										curD = (d + leadDim) % dimLen;
										curPosition[curD]++;
										if (curPosition[curD] < idxOffset[curD].Length) {
											break;
										}
										curPosition[curD] = 0;
										d++;
									}
                                    tmpIn = pInArr + A.m_indexOffset.IndexFromArray(curPosition); 
								}
							}
						}
					}
#endregion
				}
				// ==============================================================
#endregion
			} else {
				// physical -> pointer arithmetic
                if (leadDim == 0) {
#region physical along 1st leading dimension
                    unsafe {
                        fixed ( byte * pOutArr = retDblArr)
                        fixed ( UInt16 * pInArr = A.m_data) {
                            UInt16 * lastElement;
                            byte * tmpOut = pOutArr;
                            UInt16 * tmpIn = pInArr;
                            for (int h = nrHigherDims; h-- > 0; ) {
								lastElement = tmpIn + leadDimLen;
                                
                                while (tmpIn < lastElement) {
                                    UInt16 inVal = *(tmpIn++); 
                                    /**/
                                    tmpCount +=  ( (inVal)   == 0)?0:1;
                                }
                                *tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; 
                                tmpOut++;
                            }
                        }
					}
#endregion
				} else {
#region physical along abitrary dimension
					// sum along abitrary dimension 
                    unsafe {
                        fixed ( byte * pOutArr = retDblArr)
                        fixed ( UInt16 * pInArr = A.m_data) {
                            byte * lastElementOut = newLength + pOutArr -1;
                            int inLength = inDim.NumberOfElements -1; 
                            UInt16 * lastElementIn = pInArr + inLength; 
                            int inc = inDim.SequentialIndexDistance(leadDim); 
                            byte * tmpOut = pOutArr;
                            int outLength = newLength - 1;
                            UInt16 * leadEnd; 
                            UInt16 * tmpIn = pInArr;
                            for (int h = nrHigherDims; h--> 0; ) {
								leadEnd = tmpIn + leadDimLen * inc;
                                
                                while (tmpIn < leadEnd) {
                                    UInt16 inVal = *(tmpIn); 
                                    tmpIn += inc; 
                                    /**/
                                    tmpCount +=  ( (inVal)   == 0)?0:1;
                                }
                                *tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; 
                                tmpOut  += inc;
                                if (tmpOut > lastElementOut)
                                    tmpOut = pOutArr + ((tmpOut - pOutArr) - outLength);
                                if (tmpIn > lastElementIn)
                                    tmpIn = pInArr + ((tmpIn - pInArr) - inLength); 
                            }
                        }
					}
#endregion
				}
			}
			return new  ILLogicalArray (retDblArr, newDims);;
        }
        /// <summary>determine, if all elements are nonzero</summary>
		/// <param name="A">N-dimensional array</param>
		/// <param name="leadDim">index of dimension to operate along</param>
		/// <returns><para>array of same size as A, having 'leadDim's dimension reduced to 1, if all elements along that dimension are nonzero, '0' else. </para></returns>
        public static  ILLogicalArray  all ( ILArray<Int64> A, int leadDim) {
            if (leadDim >= A.Dimensions.NumberOfDimensions)
                throw new ILArgumentException("dimension parameter out of range!");
            if (A.IsEmpty)       
                return  ILLogicalArray .empty(A.Dimensions); 
            if (A.IsScalar) {
                return new ILLogicalArray (new byte [1]{(A.GetValue(0) == 0)?(byte)0:(byte)1},1,1);
            }
            ILDimension inDim = A.Dimensions; 
			int[] newDims = inDim.ToIntArray();
            int tmpCount = 0; 
			int newLength;
			 byte [] retDblArr;
			// build ILDimension
			newLength = inDim.NumberOfElements / newDims[leadDim];
			newDims[leadDim] = 1;
			retDblArr = ILMemoryPool.Pool.New< byte >(newLength);
            ILDimension newDimension = new ILDimension(newDims); 
            int incOut = newDimension.SequentialIndexDistance(leadDim); 
            int leadDimLen = inDim[leadDim];
            int posCounter; 
			int nrHigherDims = inDim.NumberOfElements / leadDimLen;
            if (A.IsReference) {
#region Reference storage
				// ========================  REFERENCE double Storage ===========
				if (A.IsMatrix) {
#region Matrix
					////////////////////////////   MATRIX   ///////////////////////
					unsafe {
						ILIndexOffset idxOffset = A.m_indexOffset;
						int secDim = (leadDim + 1) % 2;
						fixed (int* leadDimStart = idxOffset[leadDim],
								secDimStart = idxOffset[secDim]) {
							fixed ( byte * pOutArr = retDblArr)
						    fixed ( Int64 * pInArr = A.m_data) {
								 byte * tmpOut = pOutArr;
								 byte * lastElementOut = tmpOut + retDblArr.Length;
								 Int64 * tmpIn = pInArr;
								int* secDimEnd = secDimStart + idxOffset[secDim].Length - 1;
								int* secDimIdx = secDimStart; 
								int* leadDimIdx = leadDimStart;
								int* leadDimEnd = leadDimStart + leadDimLen - 1;
								// start at first element
								while (secDimIdx <= secDimEnd) {
									tmpIn = pInArr + *secDimIdx++; 
									leadDimIdx = leadDimStart;
                                    
									while (leadDimIdx <= leadDimEnd) {
                                        Int64 inVal = *(tmpIn + *leadDimIdx++); 
                                        /**/
										 tmpCount +=  ( (inVal)   == 0)?0:1;
									}
                                    *tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; 
                                    tmpOut++;
								}
							}
						}
					} 
#endregion
				} else {
					/////////////////////////////   ARBITRARY DIMENSIONS //////////
#region arbitrary size
					unsafe {
						ILIndexOffset idxOffset = A.m_indexOffset;
						int[] curPosition = new int[A.Dimensions.NumberOfDimensions];
						fixed (int* leadDimStart = idxOffset[leadDim]) {
							fixed ( byte * pOutArr = retDblArr)
							fixed ( Int64 * pInArr = A.m_data) {
								 byte * tmpOut = pOutArr;
								 byte * lastElementOut = tmpOut + retDblArr.Length - 1;
								 Int64 * tmpIn = pInArr + A.m_indexOffset.Map(0);
								int* leadDimIdx = leadDimStart;
								int* leadDimEnd = leadDimStart + leadDimLen;
								int dimLen = curPosition.Length;
								int d, curD;
								// start at first element
                                posCounter = retDblArr.Length; 
								while (posCounter-->0) {
									leadDimIdx = leadDimStart;
                                    
									while (leadDimIdx < leadDimEnd){
                                        Int64 inVal = *(tmpIn + *leadDimIdx++); 
                                        /**/
										 tmpCount +=  ( (inVal)   == 0)?0:1;
                                    *tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; 
                                    }
                                    tmpOut += incOut;
                                    if (tmpOut > lastElementOut)
                                        tmpOut -= (retDblArr.Length - 1);
									// increment higher dimensions 
									d = 1;
									while (d < dimLen) {
										curD = (d + leadDim) % dimLen;
										curPosition[curD]++;
										if (curPosition[curD] < idxOffset[curD].Length) {
											break;
										}
										curPosition[curD] = 0;
										d++;
									}
                                    tmpIn = pInArr + A.m_indexOffset.IndexFromArray(curPosition); 
								}
							}
						}
					}
#endregion
				}
				// ==============================================================
#endregion
			} else {
				// physical -> pointer arithmetic
                if (leadDim == 0) {
#region physical along 1st leading dimension
                    unsafe {
                        fixed ( byte * pOutArr = retDblArr)
                        fixed ( Int64 * pInArr = A.m_data) {
                            Int64 * lastElement;
                            byte * tmpOut = pOutArr;
                            Int64 * tmpIn = pInArr;
                            for (int h = nrHigherDims; h-- > 0; ) {
								lastElement = tmpIn + leadDimLen;
                                
                                while (tmpIn < lastElement) {
                                    Int64 inVal = *(tmpIn++); 
                                    /**/
                                    tmpCount +=  ( (inVal)   == 0)?0:1;
                                }
                                *tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; 
                                tmpOut++;
                            }
                        }
					}
#endregion
				} else {
#region physical along abitrary dimension
					// sum along abitrary dimension 
                    unsafe {
                        fixed ( byte * pOutArr = retDblArr)
                        fixed ( Int64 * pInArr = A.m_data) {
                            byte * lastElementOut = newLength + pOutArr -1;
                            int inLength = inDim.NumberOfElements -1; 
                            Int64 * lastElementIn = pInArr + inLength; 
                            int inc = inDim.SequentialIndexDistance(leadDim); 
                            byte * tmpOut = pOutArr;
                            int outLength = newLength - 1;
                            Int64 * leadEnd; 
                            Int64 * tmpIn = pInArr;
                            for (int h = nrHigherDims; h--> 0; ) {
								leadEnd = tmpIn + leadDimLen * inc;
                                
                                while (tmpIn < leadEnd) {
                                    Int64 inVal = *(tmpIn); 
                                    tmpIn += inc; 
                                    /**/
                                    tmpCount +=  ( (inVal)   == 0)?0:1;
                                }
                                *tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; 
                                tmpOut  += inc;
                                if (tmpOut > lastElementOut)
                                    tmpOut = pOutArr + ((tmpOut - pOutArr) - outLength);
                                if (tmpIn > lastElementIn)
                                    tmpIn = pInArr + ((tmpIn - pInArr) - inLength); 
                            }
                        }
					}
#endregion
				}
			}
			return new  ILLogicalArray (retDblArr, newDims);;
        }
        /// <summary>determine, if all elements are nonzero</summary>
		/// <param name="A">N-dimensional array</param>
		/// <param name="leadDim">index of dimension to operate along</param>
		/// <returns><para>array of same size as A, having 'leadDim's dimension reduced to 1, if all elements along that dimension are nonzero, '0' else. </para></returns>
        public static  ILLogicalArray  all ( ILArray<Int32> A, int leadDim) {
            if (leadDim >= A.Dimensions.NumberOfDimensions)
                throw new ILArgumentException("dimension parameter out of range!");
            if (A.IsEmpty)       
                return  ILLogicalArray .empty(A.Dimensions); 
            if (A.IsScalar) {
                return new ILLogicalArray (new byte [1]{(A.GetValue(0) == 0)?(byte)0:(byte)1},1,1);
            }
            ILDimension inDim = A.Dimensions; 
			int[] newDims = inDim.ToIntArray();
            int tmpCount = 0; 
			int newLength;
			 byte [] retDblArr;
			// build ILDimension
			newLength = inDim.NumberOfElements / newDims[leadDim];
			newDims[leadDim] = 1;
			retDblArr = ILMemoryPool.Pool.New< byte >(newLength);
            ILDimension newDimension = new ILDimension(newDims); 
            int incOut = newDimension.SequentialIndexDistance(leadDim); 
            int leadDimLen = inDim[leadDim];
            int posCounter; 
			int nrHigherDims = inDim.NumberOfElements / leadDimLen;
            if (A.IsReference) {
#region Reference storage
				// ========================  REFERENCE double Storage ===========
				if (A.IsMatrix) {
#region Matrix
					////////////////////////////   MATRIX   ///////////////////////
					unsafe {
						ILIndexOffset idxOffset = A.m_indexOffset;
						int secDim = (leadDim + 1) % 2;
						fixed (int* leadDimStart = idxOffset[leadDim],
								secDimStart = idxOffset[secDim]) {
							fixed ( byte * pOutArr = retDblArr)
						    fixed ( Int32 * pInArr = A.m_data) {
								 byte * tmpOut = pOutArr;
								 byte * lastElementOut = tmpOut + retDblArr.Length;
								 Int32 * tmpIn = pInArr;
								int* secDimEnd = secDimStart + idxOffset[secDim].Length - 1;
								int* secDimIdx = secDimStart; 
								int* leadDimIdx = leadDimStart;
								int* leadDimEnd = leadDimStart + leadDimLen - 1;
								// start at first element
								while (secDimIdx <= secDimEnd) {
									tmpIn = pInArr + *secDimIdx++; 
									leadDimIdx = leadDimStart;
                                    
									while (leadDimIdx <= leadDimEnd) {
                                        Int32 inVal = *(tmpIn + *leadDimIdx++); 
                                        /**/
										 tmpCount +=  ( (inVal)   == 0)?0:1;
									}
                                    *tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; 
                                    tmpOut++;
								}
							}
						}
					} 
#endregion
				} else {
					/////////////////////////////   ARBITRARY DIMENSIONS //////////
#region arbitrary size
					unsafe {
						ILIndexOffset idxOffset = A.m_indexOffset;
						int[] curPosition = new int[A.Dimensions.NumberOfDimensions];
						fixed (int* leadDimStart = idxOffset[leadDim]) {
							fixed ( byte * pOutArr = retDblArr)
							fixed ( Int32 * pInArr = A.m_data) {
								 byte * tmpOut = pOutArr;
								 byte * lastElementOut = tmpOut + retDblArr.Length - 1;
								 Int32 * tmpIn = pInArr + A.m_indexOffset.Map(0);
								int* leadDimIdx = leadDimStart;
								int* leadDimEnd = leadDimStart + leadDimLen;
								int dimLen = curPosition.Length;
								int d, curD;
								// start at first element
                                posCounter = retDblArr.Length; 
								while (posCounter-->0) {
									leadDimIdx = leadDimStart;
                                    
									while (leadDimIdx < leadDimEnd){
                                        Int32 inVal = *(tmpIn + *leadDimIdx++); 
                                        /**/
										 tmpCount +=  ( (inVal)   == 0)?0:1;
                                    *tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; 
                                    }
                                    tmpOut += incOut;
                                    if (tmpOut > lastElementOut)
                                        tmpOut -= (retDblArr.Length - 1);
									// increment higher dimensions 
									d = 1;
									while (d < dimLen) {
										curD = (d + leadDim) % dimLen;
										curPosition[curD]++;
										if (curPosition[curD] < idxOffset[curD].Length) {
											break;
										}
										curPosition[curD] = 0;
										d++;
									}
                                    tmpIn = pInArr + A.m_indexOffset.IndexFromArray(curPosition); 
								}
							}
						}
					}
#endregion
				}
				// ==============================================================
#endregion
			} else {
				// physical -> pointer arithmetic
                if (leadDim == 0) {
#region physical along 1st leading dimension
                    unsafe {
                        fixed ( byte * pOutArr = retDblArr)
                        fixed ( Int32 * pInArr = A.m_data) {
                            Int32 * lastElement;
                            byte * tmpOut = pOutArr;
                            Int32 * tmpIn = pInArr;
                            for (int h = nrHigherDims; h-- > 0; ) {
								lastElement = tmpIn + leadDimLen;
                                
                                while (tmpIn < lastElement) {
                                    Int32 inVal = *(tmpIn++); 
                                    /**/
                                    tmpCount +=  ( (inVal)   == 0)?0:1;
                                }
                                *tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; 
                                tmpOut++;
                            }
                        }
					}
#endregion
				} else {
#region physical along abitrary dimension
					// sum along abitrary dimension 
                    unsafe {
                        fixed ( byte * pOutArr = retDblArr)
                        fixed ( Int32 * pInArr = A.m_data) {
                            byte * lastElementOut = newLength + pOutArr -1;
                            int inLength = inDim.NumberOfElements -1; 
                            Int32 * lastElementIn = pInArr + inLength; 
                            int inc = inDim.SequentialIndexDistance(leadDim); 
                            byte * tmpOut = pOutArr;
                            int outLength = newLength - 1;
                            Int32 * leadEnd; 
                            Int32 * tmpIn = pInArr;
                            for (int h = nrHigherDims; h--> 0; ) {
								leadEnd = tmpIn + leadDimLen * inc;
                                
                                while (tmpIn < leadEnd) {
                                    Int32 inVal = *(tmpIn); 
                                    tmpIn += inc; 
                                    /**/
                                    tmpCount +=  ( (inVal)   == 0)?0:1;
                                }
                                *tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; 
                                tmpOut  += inc;
                                if (tmpOut > lastElementOut)
                                    tmpOut = pOutArr + ((tmpOut - pOutArr) - outLength);
                                if (tmpIn > lastElementIn)
                                    tmpIn = pInArr + ((tmpIn - pInArr) - inLength); 
                            }
                        }
					}
#endregion
				}
			}
			return new  ILLogicalArray (retDblArr, newDims);;
        }
        /// <summary>determine, if all elements are nonzero</summary>
		/// <param name="A">N-dimensional array</param>
		/// <param name="leadDim">index of dimension to operate along</param>
		/// <returns><para>array of same size as A, having 'leadDim's dimension reduced to 1, if all elements along that dimension are nonzero, '0' else. </para></returns>
        public static  ILLogicalArray  all ( ILArray<Int16> A, int leadDim) {
            if (leadDim >= A.Dimensions.NumberOfDimensions)
                throw new ILArgumentException("dimension parameter out of range!");
            if (A.IsEmpty)       
                return  ILLogicalArray .empty(A.Dimensions); 
            if (A.IsScalar) {
                return new ILLogicalArray (new byte [1]{(A.GetValue(0) == 0)?(byte)0:(byte)1},1,1);
            }
            ILDimension inDim = A.Dimensions; 
			int[] newDims = inDim.ToIntArray();
            int tmpCount = 0; 
			int newLength;
			 byte [] retDblArr;
			// build ILDimension
			newLength = inDim.NumberOfElements / newDims[leadDim];
			newDims[leadDim] = 1;
			retDblArr = ILMemoryPool.Pool.New< byte >(newLength);
            ILDimension newDimension = new ILDimension(newDims); 
            int incOut = newDimension.SequentialIndexDistance(leadDim); 
            int leadDimLen = inDim[leadDim];
            int posCounter; 
			int nrHigherDims = inDim.NumberOfElements / leadDimLen;
            if (A.IsReference) {
#region Reference storage
				// ========================  REFERENCE double Storage ===========
				if (A.IsMatrix) {
#region Matrix
					////////////////////////////   MATRIX   ///////////////////////
					unsafe {
						ILIndexOffset idxOffset = A.m_indexOffset;
						int secDim = (leadDim + 1) % 2;
						fixed (int* leadDimStart = idxOffset[leadDim],
								secDimStart = idxOffset[secDim]) {
							fixed ( byte * pOutArr = retDblArr)
						    fixed ( Int16 * pInArr = A.m_data) {
								 byte * tmpOut = pOutArr;
								 byte * lastElementOut = tmpOut + retDblArr.Length;
								 Int16 * tmpIn = pInArr;
								int* secDimEnd = secDimStart + idxOffset[secDim].Length - 1;
								int* secDimIdx = secDimStart; 
								int* leadDimIdx = leadDimStart;
								int* leadDimEnd = leadDimStart + leadDimLen - 1;
								// start at first element
								while (secDimIdx <= secDimEnd) {
									tmpIn = pInArr + *secDimIdx++; 
									leadDimIdx = leadDimStart;
                                    
									while (leadDimIdx <= leadDimEnd) {
                                        Int16 inVal = *(tmpIn + *leadDimIdx++); 
                                        /**/
										 tmpCount +=  ( (inVal)   == 0)?0:1;
									}
                                    *tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; 
                                    tmpOut++;
								}
							}
						}
					} 
#endregion
				} else {
					/////////////////////////////   ARBITRARY DIMENSIONS //////////
#region arbitrary size
					unsafe {
						ILIndexOffset idxOffset = A.m_indexOffset;
						int[] curPosition = new int[A.Dimensions.NumberOfDimensions];
						fixed (int* leadDimStart = idxOffset[leadDim]) {
							fixed ( byte * pOutArr = retDblArr)
							fixed ( Int16 * pInArr = A.m_data) {
								 byte * tmpOut = pOutArr;
								 byte * lastElementOut = tmpOut + retDblArr.Length - 1;
								 Int16 * tmpIn = pInArr + A.m_indexOffset.Map(0);
								int* leadDimIdx = leadDimStart;
								int* leadDimEnd = leadDimStart + leadDimLen;
								int dimLen = curPosition.Length;
								int d, curD;
								// start at first element
                                posCounter = retDblArr.Length; 
								while (posCounter-->0) {
									leadDimIdx = leadDimStart;
                                    
									while (leadDimIdx < leadDimEnd){
                                        Int16 inVal = *(tmpIn + *leadDimIdx++); 
                                        /**/
										 tmpCount +=  ( (inVal)   == 0)?0:1;
                                    *tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; 
                                    }
                                    tmpOut += incOut;
                                    if (tmpOut > lastElementOut)
                                        tmpOut -= (retDblArr.Length - 1);
									// increment higher dimensions 
									d = 1;
									while (d < dimLen) {
										curD = (d + leadDim) % dimLen;
										curPosition[curD]++;
										if (curPosition[curD] < idxOffset[curD].Length) {
											break;
										}
										curPosition[curD] = 0;
										d++;
									}
                                    tmpIn = pInArr + A.m_indexOffset.IndexFromArray(curPosition); 
								}
							}
						}
					}
#endregion
				}
				// ==============================================================
#endregion
			} else {
				// physical -> pointer arithmetic
                if (leadDim == 0) {
#region physical along 1st leading dimension
                    unsafe {
                        fixed ( byte * pOutArr = retDblArr)
                        fixed ( Int16 * pInArr = A.m_data) {
                            Int16 * lastElement;
                            byte * tmpOut = pOutArr;
                            Int16 * tmpIn = pInArr;
                            for (int h = nrHigherDims; h-- > 0; ) {
								lastElement = tmpIn + leadDimLen;
                                
                                while (tmpIn < lastElement) {
                                    Int16 inVal = *(tmpIn++); 
                                    /**/
                                    tmpCount +=  ( (inVal)   == 0)?0:1;
                                }
                                *tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; 
                                tmpOut++;
                            }
                        }
					}
#endregion
				} else {
#region physical along abitrary dimension
					// sum along abitrary dimension 
                    unsafe {
                        fixed ( byte * pOutArr = retDblArr)
                        fixed ( Int16 * pInArr = A.m_data) {
                            byte * lastElementOut = newLength + pOutArr -1;
                            int inLength = inDim.NumberOfElements -1; 
                            Int16 * lastElementIn = pInArr + inLength; 
                            int inc = inDim.SequentialIndexDistance(leadDim); 
                            byte * tmpOut = pOutArr;
                            int outLength = newLength - 1;
                            Int16 * leadEnd; 
                            Int16 * tmpIn = pInArr;
                            for (int h = nrHigherDims; h--> 0; ) {
								leadEnd = tmpIn + leadDimLen * inc;
                                
                                while (tmpIn < leadEnd) {
                                    Int16 inVal = *(tmpIn); 
                                    tmpIn += inc; 
                                    /**/
                                    tmpCount +=  ( (inVal)   == 0)?0:1;
                                }
                                *tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; 
                                tmpOut  += inc;
                                if (tmpOut > lastElementOut)
                                    tmpOut = pOutArr + ((tmpOut - pOutArr) - outLength);
                                if (tmpIn > lastElementIn)
                                    tmpIn = pInArr + ((tmpIn - pInArr) - inLength); 
                            }
                        }
					}
#endregion
				}
			}
			return new  ILLogicalArray (retDblArr, newDims);;
        }
        /// <summary>determine, if all elements are nonzero</summary>
		/// <param name="A">N-dimensional array</param>
		/// <param name="leadDim">index of dimension to operate along</param>
		/// <returns><para>array of same size as A, having 'leadDim's dimension reduced to 1, if all elements along that dimension are nonzero, '0' else. </para></returns>
        public static  ILLogicalArray  all ( ILArray<char> A, int leadDim) {
            if (leadDim >= A.Dimensions.NumberOfDimensions)
                throw new ILArgumentException("dimension parameter out of range!");
            if (A.IsEmpty)       
                return  ILLogicalArray .empty(A.Dimensions); 
            if (A.IsScalar) {
                return new ILLogicalArray (new byte [1]{(A.GetValue(0) == 0)?(byte)0:(byte)1},1,1);
            }
            ILDimension inDim = A.Dimensions; 
			int[] newDims = inDim.ToIntArray();
            int tmpCount = 0; 
			int newLength;
			 byte [] retDblArr;
			// build ILDimension
			newLength = inDim.NumberOfElements / newDims[leadDim];
			newDims[leadDim] = 1;
			retDblArr = ILMemoryPool.Pool.New< byte >(newLength);
            ILDimension newDimension = new ILDimension(newDims); 
            int incOut = newDimension.SequentialIndexDistance(leadDim); 
            int leadDimLen = inDim[leadDim];
            int posCounter; 
			int nrHigherDims = inDim.NumberOfElements / leadDimLen;
            if (A.IsReference) {
#region Reference storage
				// ========================  REFERENCE double Storage ===========
				if (A.IsMatrix) {
#region Matrix
					////////////////////////////   MATRIX   ///////////////////////
					unsafe {
						ILIndexOffset idxOffset = A.m_indexOffset;
						int secDim = (leadDim + 1) % 2;
						fixed (int* leadDimStart = idxOffset[leadDim],
								secDimStart = idxOffset[secDim]) {
							fixed ( byte * pOutArr = retDblArr)
						    fixed ( char * pInArr = A.m_data) {
								 byte * tmpOut = pOutArr;
								 byte * lastElementOut = tmpOut + retDblArr.Length;
								 char * tmpIn = pInArr;
								int* secDimEnd = secDimStart + idxOffset[secDim].Length - 1;
								int* secDimIdx = secDimStart; 
								int* leadDimIdx = leadDimStart;
								int* leadDimEnd = leadDimStart + leadDimLen - 1;
								// start at first element
								while (secDimIdx <= secDimEnd) {
									tmpIn = pInArr + *secDimIdx++; 
									leadDimIdx = leadDimStart;
                                    
									while (leadDimIdx <= leadDimEnd) {
                                        char inVal = *(tmpIn + *leadDimIdx++); 
                                        /**/
										 tmpCount +=  ( (inVal)   == 0)?0:1;
									}
                                    *tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; 
                                    tmpOut++;
								}
							}
						}
					} 
#endregion
				} else {
					/////////////////////////////   ARBITRARY DIMENSIONS //////////
#region arbitrary size
					unsafe {
						ILIndexOffset idxOffset = A.m_indexOffset;
						int[] curPosition = new int[A.Dimensions.NumberOfDimensions];
						fixed (int* leadDimStart = idxOffset[leadDim]) {
							fixed ( byte * pOutArr = retDblArr)
							fixed ( char * pInArr = A.m_data) {
								 byte * tmpOut = pOutArr;
								 byte * lastElementOut = tmpOut + retDblArr.Length - 1;
								 char * tmpIn = pInArr + A.m_indexOffset.Map(0);
								int* leadDimIdx = leadDimStart;
								int* leadDimEnd = leadDimStart + leadDimLen;
								int dimLen = curPosition.Length;
								int d, curD;
								// start at first element
                                posCounter = retDblArr.Length; 
								while (posCounter-->0) {
									leadDimIdx = leadDimStart;
                                    
									while (leadDimIdx < leadDimEnd){
                                        char inVal = *(tmpIn + *leadDimIdx++); 
                                        /**/
										 tmpCount +=  ( (inVal)   == 0)?0:1;
                                    *tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; 
                                    }
                                    tmpOut += incOut;
                                    if (tmpOut > lastElementOut)
                                        tmpOut -= (retDblArr.Length - 1);
									// increment higher dimensions 
									d = 1;
									while (d < dimLen) {
										curD = (d + leadDim) % dimLen;
										curPosition[curD]++;
										if (curPosition[curD] < idxOffset[curD].Length) {
											break;
										}
										curPosition[curD] = 0;
										d++;
									}
                                    tmpIn = pInArr + A.m_indexOffset.IndexFromArray(curPosition); 
								}
							}
						}
					}
#endregion
				}
				// ==============================================================
#endregion
			} else {
				// physical -> pointer arithmetic
                if (leadDim == 0) {
#region physical along 1st leading dimension
                    unsafe {
                        fixed ( byte * pOutArr = retDblArr)
                        fixed ( char * pInArr = A.m_data) {
                            char * lastElement;
                            byte * tmpOut = pOutArr;
                            char * tmpIn = pInArr;
                            for (int h = nrHigherDims; h-- > 0; ) {
								lastElement = tmpIn + leadDimLen;
                                
                                while (tmpIn < lastElement) {
                                    char inVal = *(tmpIn++); 
                                    /**/
                                    tmpCount +=  ( (inVal)   == 0)?0:1;
                                }
                                *tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; 
                                tmpOut++;
                            }
                        }
					}
#endregion
				} else {
#region physical along abitrary dimension
					// sum along abitrary dimension 
                    unsafe {
                        fixed ( byte * pOutArr = retDblArr)
                        fixed ( char * pInArr = A.m_data) {
                            byte * lastElementOut = newLength + pOutArr -1;
                            int inLength = inDim.NumberOfElements -1; 
                            char * lastElementIn = pInArr + inLength; 
                            int inc = inDim.SequentialIndexDistance(leadDim); 
                            byte * tmpOut = pOutArr;
                            int outLength = newLength - 1;
                            char * leadEnd; 
                            char * tmpIn = pInArr;
                            for (int h = nrHigherDims; h--> 0; ) {
								leadEnd = tmpIn + leadDimLen * inc;
                                
                                while (tmpIn < leadEnd) {
                                    char inVal = *(tmpIn); 
                                    tmpIn += inc; 
                                    /**/
                                    tmpCount +=  ( (inVal)   == 0)?0:1;
                                }
                                *tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; 
                                tmpOut  += inc;
                                if (tmpOut > lastElementOut)
                                    tmpOut = pOutArr + ((tmpOut - pOutArr) - outLength);
                                if (tmpIn > lastElementIn)
                                    tmpIn = pInArr + ((tmpIn - pInArr) - inLength); 
                            }
                        }
					}
#endregion
				}
			}
			return new  ILLogicalArray (retDblArr, newDims);;
        }
        /// <summary>determine, if all elements are nonzero</summary>
		/// <param name="A">N-dimensional array</param>
		/// <param name="leadDim">index of dimension to operate along</param>
		/// <returns><para>array of same size as A, having 'leadDim's dimension reduced to 1, if all elements along that dimension are nonzero, '0' else. </para></returns>
        public static  ILLogicalArray  all ( ILArray<byte> A, int leadDim) {
            if (leadDim >= A.Dimensions.NumberOfDimensions)
                throw new ILArgumentException("dimension parameter out of range!");
            if (A.IsEmpty)       
                return  ILLogicalArray .empty(A.Dimensions); 
            if (A.IsScalar) {
                return new ILLogicalArray (new byte [1]{(A.GetValue(0) == 0)?(byte)0:(byte)1},1,1);
            }
            ILDimension inDim = A.Dimensions; 
			int[] newDims = inDim.ToIntArray();
            int tmpCount = 0; 
			int newLength;
			 byte [] retDblArr;
			// build ILDimension
			newLength = inDim.NumberOfElements / newDims[leadDim];
			newDims[leadDim] = 1;
			retDblArr = ILMemoryPool.Pool.New< byte >(newLength);
            ILDimension newDimension = new ILDimension(newDims); 
            int incOut = newDimension.SequentialIndexDistance(leadDim); 
            int leadDimLen = inDim[leadDim];
            int posCounter; 
			int nrHigherDims = inDim.NumberOfElements / leadDimLen;
            if (A.IsReference) {
#region Reference storage
				// ========================  REFERENCE double Storage ===========
				if (A.IsMatrix) {
#region Matrix
					////////////////////////////   MATRIX   ///////////////////////
					unsafe {
						ILIndexOffset idxOffset = A.m_indexOffset;
						int secDim = (leadDim + 1) % 2;
						fixed (int* leadDimStart = idxOffset[leadDim],
								secDimStart = idxOffset[secDim]) {
							fixed ( byte * pOutArr = retDblArr)
						    fixed ( byte * pInArr = A.m_data) {
								 byte * tmpOut = pOutArr;
								 byte * lastElementOut = tmpOut + retDblArr.Length;
								 byte * tmpIn = pInArr;
								int* secDimEnd = secDimStart + idxOffset[secDim].Length - 1;
								int* secDimIdx = secDimStart; 
								int* leadDimIdx = leadDimStart;
								int* leadDimEnd = leadDimStart + leadDimLen - 1;
								// start at first element
								while (secDimIdx <= secDimEnd) {
									tmpIn = pInArr + *secDimIdx++; 
									leadDimIdx = leadDimStart;
                                    
									while (leadDimIdx <= leadDimEnd) {
                                        byte inVal = *(tmpIn + *leadDimIdx++); 
                                        /**/
										 tmpCount +=  ( (inVal)   == 0)?0:1;
									}
                                    *tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; 
                                    tmpOut++;
								}
							}
						}
					} 
#endregion
				} else {
					/////////////////////////////   ARBITRARY DIMENSIONS //////////
#region arbitrary size
					unsafe {
						ILIndexOffset idxOffset = A.m_indexOffset;
						int[] curPosition = new int[A.Dimensions.NumberOfDimensions];
						fixed (int* leadDimStart = idxOffset[leadDim]) {
							fixed ( byte * pOutArr = retDblArr)
							fixed ( byte * pInArr = A.m_data) {
								 byte * tmpOut = pOutArr;
								 byte * lastElementOut = tmpOut + retDblArr.Length - 1;
								 byte * tmpIn = pInArr + A.m_indexOffset.Map(0);
								int* leadDimIdx = leadDimStart;
								int* leadDimEnd = leadDimStart + leadDimLen;
								int dimLen = curPosition.Length;
								int d, curD;
								// start at first element
                                posCounter = retDblArr.Length; 
								while (posCounter-->0) {
									leadDimIdx = leadDimStart;
                                    
									while (leadDimIdx < leadDimEnd){
                                        byte inVal = *(tmpIn + *leadDimIdx++); 
                                        /**/
										 tmpCount +=  ( (inVal)   == 0)?0:1;
                                    *tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; 
                                    }
                                    tmpOut += incOut;
                                    if (tmpOut > lastElementOut)
                                        tmpOut -= (retDblArr.Length - 1);
									// increment higher dimensions 
									d = 1;
									while (d < dimLen) {
										curD = (d + leadDim) % dimLen;
										curPosition[curD]++;
										if (curPosition[curD] < idxOffset[curD].Length) {
											break;
										}
										curPosition[curD] = 0;
										d++;
									}
                                    tmpIn = pInArr + A.m_indexOffset.IndexFromArray(curPosition); 
								}
							}
						}
					}
#endregion
				}
				// ==============================================================
#endregion
			} else {
				// physical -> pointer arithmetic
                if (leadDim == 0) {
#region physical along 1st leading dimension
                    unsafe {
                        fixed ( byte * pOutArr = retDblArr)
                        fixed ( byte * pInArr = A.m_data) {
                            byte * lastElement;
                            byte * tmpOut = pOutArr;
                            byte * tmpIn = pInArr;
                            for (int h = nrHigherDims; h-- > 0; ) {
								lastElement = tmpIn + leadDimLen;
                                
                                while (tmpIn < lastElement) {
                                    byte inVal = *(tmpIn++); 
                                    /**/
                                    tmpCount +=  ( (inVal)   == 0)?0:1;
                                }
                                *tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; 
                                tmpOut++;
                            }
                        }
					}
#endregion
				} else {
#region physical along abitrary dimension
					// sum along abitrary dimension 
                    unsafe {
                        fixed ( byte * pOutArr = retDblArr)
                        fixed ( byte * pInArr = A.m_data) {
                            byte * lastElementOut = newLength + pOutArr -1;
                            int inLength = inDim.NumberOfElements -1; 
                            byte * lastElementIn = pInArr + inLength; 
                            int inc = inDim.SequentialIndexDistance(leadDim); 
                            byte * tmpOut = pOutArr;
                            int outLength = newLength - 1;
                            byte * leadEnd; 
                            byte * tmpIn = pInArr;
                            for (int h = nrHigherDims; h--> 0; ) {
								leadEnd = tmpIn + leadDimLen * inc;
                                
                                while (tmpIn < leadEnd) {
                                    byte inVal = *(tmpIn); 
                                    tmpIn += inc; 
                                    /**/
                                    tmpCount +=  ( (inVal)   == 0)?0:1;
                                }
                                *tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; 
                                tmpOut  += inc;
                                if (tmpOut > lastElementOut)
                                    tmpOut = pOutArr + ((tmpOut - pOutArr) - outLength);
                                if (tmpIn > lastElementIn)
                                    tmpIn = pInArr + ((tmpIn - pInArr) - inLength); 
                            }
                        }
					}
#endregion
				}
			}
			return new  ILLogicalArray (retDblArr, newDims);;
        }
        /// <summary>determine, if all elements are nonzero</summary>
		/// <param name="A">N-dimensional array</param>
		/// <param name="leadDim">index of dimension to operate along</param>
		/// <returns><para>array of same size as A, having 'leadDim's dimension reduced to 1, if all elements along that dimension are nonzero, '0' else. </para></returns>
        public static  ILLogicalArray  all ( ILArray<fcomplex> A, int leadDim) {
            if (leadDim >= A.Dimensions.NumberOfDimensions)
                throw new ILArgumentException("dimension parameter out of range!");
            if (A.IsEmpty)       
                return  ILLogicalArray .empty(A.Dimensions); 
            if (A.IsScalar) {
                return new ILLogicalArray (new byte [1]{(A.GetValue(0).iszero())?(byte)1:(byte)0},1,1);
            }
            ILDimension inDim = A.Dimensions; 
			int[] newDims = inDim.ToIntArray();
            int tmpCount = 0; 
			int newLength;
			 byte [] retDblArr;
			// build ILDimension
			newLength = inDim.NumberOfElements / newDims[leadDim];
			newDims[leadDim] = 1;
			retDblArr = ILMemoryPool.Pool.New< byte >(newLength);
            ILDimension newDimension = new ILDimension(newDims); 
            int incOut = newDimension.SequentialIndexDistance(leadDim); 
            int leadDimLen = inDim[leadDim];
            int posCounter; 
			int nrHigherDims = inDim.NumberOfElements / leadDimLen;
            if (A.IsReference) {
#region Reference storage
				// ========================  REFERENCE double Storage ===========
				if (A.IsMatrix) {
#region Matrix
					////////////////////////////   MATRIX   ///////////////////////
					unsafe {
						ILIndexOffset idxOffset = A.m_indexOffset;
						int secDim = (leadDim + 1) % 2;
						fixed (int* leadDimStart = idxOffset[leadDim],
								secDimStart = idxOffset[secDim]) {
							fixed ( byte * pOutArr = retDblArr)
						    fixed ( fcomplex * pInArr = A.m_data) {
								 byte * tmpOut = pOutArr;
								 byte * lastElementOut = tmpOut + retDblArr.Length;
								 fcomplex * tmpIn = pInArr;
								int* secDimEnd = secDimStart + idxOffset[secDim].Length - 1;
								int* secDimIdx = secDimStart; 
								int* leadDimIdx = leadDimStart;
								int* leadDimEnd = leadDimStart + leadDimLen - 1;
								// start at first element
								while (secDimIdx <= secDimEnd) {
									tmpIn = pInArr + *secDimIdx++; 
									leadDimIdx = leadDimStart;
                                    
									while (leadDimIdx <= leadDimEnd) {
                                        fcomplex inVal = *(tmpIn + *leadDimIdx++); 
                                        /**/
										 tmpCount +=  ( (inVal)  .iszero())?0:1; 
									}
                                    *tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; 
                                    tmpOut++;
								}
							}
						}
					} 
#endregion
				} else {
					/////////////////////////////   ARBITRARY DIMENSIONS //////////
#region arbitrary size
					unsafe {
						ILIndexOffset idxOffset = A.m_indexOffset;
						int[] curPosition = new int[A.Dimensions.NumberOfDimensions];
						fixed (int* leadDimStart = idxOffset[leadDim]) {
							fixed ( byte * pOutArr = retDblArr)
							fixed ( fcomplex * pInArr = A.m_data) {
								 byte * tmpOut = pOutArr;
								 byte * lastElementOut = tmpOut + retDblArr.Length - 1;
								 fcomplex * tmpIn = pInArr + A.m_indexOffset.Map(0);
								int* leadDimIdx = leadDimStart;
								int* leadDimEnd = leadDimStart + leadDimLen;
								int dimLen = curPosition.Length;
								int d, curD;
								// start at first element
                                posCounter = retDblArr.Length; 
								while (posCounter-->0) {
									leadDimIdx = leadDimStart;
                                    
									while (leadDimIdx < leadDimEnd){
                                        fcomplex inVal = *(tmpIn + *leadDimIdx++); 
                                        /**/
										 tmpCount +=  ( (inVal)  .iszero())?0:1; 
                                    *tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; 
                                    }
                                    tmpOut += incOut;
                                    if (tmpOut > lastElementOut)
                                        tmpOut -= (retDblArr.Length - 1);
									// increment higher dimensions 
									d = 1;
									while (d < dimLen) {
										curD = (d + leadDim) % dimLen;
										curPosition[curD]++;
										if (curPosition[curD] < idxOffset[curD].Length) {
											break;
										}
										curPosition[curD] = 0;
										d++;
									}
                                    tmpIn = pInArr + A.m_indexOffset.IndexFromArray(curPosition); 
								}
							}
						}
					}
#endregion
				}
				// ==============================================================
#endregion
			} else {
				// physical -> pointer arithmetic
                if (leadDim == 0) {
#region physical along 1st leading dimension
                    unsafe {
                        fixed ( byte * pOutArr = retDblArr)
                        fixed ( fcomplex * pInArr = A.m_data) {
                            fcomplex * lastElement;
                            byte * tmpOut = pOutArr;
                            fcomplex * tmpIn = pInArr;
                            for (int h = nrHigherDims; h-- > 0; ) {
								lastElement = tmpIn + leadDimLen;
                                
                                while (tmpIn < lastElement) {
                                    fcomplex inVal = *(tmpIn++); 
                                    /**/
                                    tmpCount +=  ( (inVal)  .iszero())?0:1; 
                                }
                                *tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; 
                                tmpOut++;
                            }
                        }
					}
#endregion
				} else {
#region physical along abitrary dimension
					// sum along abitrary dimension 
                    unsafe {
                        fixed ( byte * pOutArr = retDblArr)
                        fixed ( fcomplex * pInArr = A.m_data) {
                            byte * lastElementOut = newLength + pOutArr -1;
                            int inLength = inDim.NumberOfElements -1; 
                            fcomplex * lastElementIn = pInArr + inLength; 
                            int inc = inDim.SequentialIndexDistance(leadDim); 
                            byte * tmpOut = pOutArr;
                            int outLength = newLength - 1;
                            fcomplex * leadEnd; 
                            fcomplex * tmpIn = pInArr;
                            for (int h = nrHigherDims; h--> 0; ) {
								leadEnd = tmpIn + leadDimLen * inc;
                                
                                while (tmpIn < leadEnd) {
                                    fcomplex inVal = *(tmpIn); 
                                    tmpIn += inc; 
                                    /**/
                                    tmpCount +=  ( (inVal)  .iszero())?0:1; 
                                }
                                *tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; 
                                tmpOut  += inc;
                                if (tmpOut > lastElementOut)
                                    tmpOut = pOutArr + ((tmpOut - pOutArr) - outLength);
                                if (tmpIn > lastElementIn)
                                    tmpIn = pInArr + ((tmpIn - pInArr) - inLength); 
                            }
                        }
					}
#endregion
				}
			}
			return new  ILLogicalArray (retDblArr, newDims);;
        }
        /// <summary>determine, if all elements are nonzero</summary>
		/// <param name="A">N-dimensional array</param>
		/// <param name="leadDim">index of dimension to operate along</param>
		/// <returns><para>array of same size as A, having 'leadDim's dimension reduced to 1, if any elements along that dimension are nonzero, '0' else. </para></returns>
        public static  ILLogicalArray  all ( ILArray<float> A, int leadDim) {
            if (leadDim >= A.Dimensions.NumberOfDimensions)
                throw new ILArgumentException("dimension parameter out of range!");
            if (A.IsEmpty)       
                return  ILLogicalArray .empty(A.Dimensions); 
            if (A.IsScalar) {
                return new ILLogicalArray (new byte [1]{(A.GetValue(0) == 0.0f)?(byte)0:(byte)1},1,1);
            }
            ILDimension inDim = A.Dimensions; 
			int[] newDims = inDim.ToIntArray();
            int tmpCount = 0; 
			int newLength;
			 byte [] retDblArr;
			// build ILDimension
			newLength = inDim.NumberOfElements / newDims[leadDim];
			newDims[leadDim] = 1;
			retDblArr = ILMemoryPool.Pool.New< byte >(newLength);
            ILDimension newDimension = new ILDimension(newDims); 
            int incOut = newDimension.SequentialIndexDistance(leadDim); 
            int leadDimLen = inDim[leadDim];
            int posCounter; 
			int nrHigherDims = inDim.NumberOfElements / leadDimLen;
            if (A.IsReference) {
#region Reference storage
				// ========================  REFERENCE double Storage ===========
				if (A.IsMatrix) {
#region Matrix
					////////////////////////////   MATRIX   ///////////////////////
					unsafe {
						ILIndexOffset idxOffset = A.m_indexOffset;
						int secDim = (leadDim + 1) % 2;
						fixed (int* leadDimStart = idxOffset[leadDim],
								secDimStart = idxOffset[secDim]) {
							fixed ( byte * pOutArr = retDblArr)
						    fixed ( float * pInArr = A.m_data) {
								 byte * tmpOut = pOutArr;
								 byte * lastElementOut = tmpOut + retDblArr.Length;
								 float * tmpIn = pInArr;
								int* secDimEnd = secDimStart + idxOffset[secDim].Length - 1;
								int* secDimIdx = secDimStart; 
								int* leadDimIdx = leadDimStart;
								int* leadDimEnd = leadDimStart + leadDimLen - 1;
								// start at first element
								while (secDimIdx <= secDimEnd) {
									tmpIn = pInArr + *secDimIdx++; 
									leadDimIdx = leadDimStart;
                                    
									while (leadDimIdx <= leadDimEnd) {
                                        float inVal = *(tmpIn + *leadDimIdx++); 
                                        /**/
										 tmpCount +=  ( (inVal)   == 0.0f)?0:1;
									}
                                    *tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; 
                                    tmpOut++;
								}
							}
						}
					} 
#endregion
				} else {
					/////////////////////////////   ARBITRARY DIMENSIONS //////////
#region arbitrary size
					unsafe {
						ILIndexOffset idxOffset = A.m_indexOffset;
						int[] curPosition = new int[A.Dimensions.NumberOfDimensions];
						fixed (int* leadDimStart = idxOffset[leadDim]) {
							fixed ( byte * pOutArr = retDblArr)
							fixed ( float * pInArr = A.m_data) {
								 byte * tmpOut = pOutArr;
								 byte * lastElementOut = tmpOut + retDblArr.Length - 1;
								 float * tmpIn = pInArr + A.m_indexOffset.Map(0);
								int* leadDimIdx = leadDimStart;
								int* leadDimEnd = leadDimStart + leadDimLen;
								int dimLen = curPosition.Length;
								int d, curD;
								// start at first element
                                posCounter = retDblArr.Length; 
								while (posCounter-->0) {
									leadDimIdx = leadDimStart;
                                    
									while (leadDimIdx < leadDimEnd){
                                        float inVal = *(tmpIn + *leadDimIdx++); 
                                        /**/
										 tmpCount +=  ( (inVal)   == 0.0f)?0:1;
                                    *tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; 
                                    }
                                    tmpOut += incOut;
                                    if (tmpOut > lastElementOut)
                                        tmpOut -= (retDblArr.Length - 1);
									// increment higher dimensions 
									d = 1;
									while (d < dimLen) {
										curD = (d + leadDim) % dimLen;
										curPosition[curD]++;
										if (curPosition[curD] < idxOffset[curD].Length) {
											break;
										}
										curPosition[curD] = 0;
										d++;
									}
                                    tmpIn = pInArr + A.m_indexOffset.IndexFromArray(curPosition); 
								}
							}
						}
					}
#endregion
				}
				// ==============================================================
#endregion
			} else {
				// physical -> pointer arithmetic
                if (leadDim == 0) {
#region physical along 1st leading dimension
                    unsafe {
                        fixed ( byte * pOutArr = retDblArr)
                        fixed ( float * pInArr = A.m_data) {
                            float * lastElement;
                            byte * tmpOut = pOutArr;
                            float * tmpIn = pInArr;
                            for (int h = nrHigherDims; h-- > 0; ) {
								lastElement = tmpIn + leadDimLen;
                                
                                while (tmpIn < lastElement) {
                                    float inVal = *(tmpIn++); 
                                    /**/
                                    tmpCount +=  ( (inVal)   == 0.0f)?0:1;
                                }
                                *tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; 
                                tmpOut++;
                            }
                        }
					}
#endregion
				} else {
#region physical along abitrary dimension
					// sum along abitrary dimension 
                    unsafe {
                        fixed ( byte * pOutArr = retDblArr)
                        fixed ( float * pInArr = A.m_data) {
                            byte * lastElementOut = newLength + pOutArr -1;
                            int inLength = inDim.NumberOfElements -1; 
                            float * lastElementIn = pInArr + inLength; 
                            int inc = inDim.SequentialIndexDistance(leadDim); 
                            byte * tmpOut = pOutArr;
                            int outLength = newLength - 1;
                            float * leadEnd; 
                            float * tmpIn = pInArr;
                            for (int h = nrHigherDims; h--> 0; ) {
								leadEnd = tmpIn + leadDimLen * inc;
                                
                                while (tmpIn < leadEnd) {
                                    float inVal = *(tmpIn); 
                                    tmpIn += inc; 
                                    /**/
                                    tmpCount +=  ( (inVal)   == 0.0f)?0:1;
                                }
                                *tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; 
                                tmpOut  += inc;
                                if (tmpOut > lastElementOut)
                                    tmpOut = pOutArr + ((tmpOut - pOutArr) - outLength);
                                if (tmpIn > lastElementIn)
                                    tmpIn = pInArr + ((tmpIn - pInArr) - inLength); 
                            }
                        }
					}
#endregion
				}
			}
			return new  ILLogicalArray (retDblArr, newDims);;
        }
        /// <summary>determine, if all elements are nonzero</summary>
		/// <param name="A">N-dimensional array</param>
		/// <param name="leadDim">index of dimension to operate along</param>
		/// <returns><para>array of same size as A, having 'leadDim's dimension reduced to 1, if any elements along that dimension are nonzero, '0' else. </para></returns>
        public static  ILLogicalArray  all ( ILArray<complex> A, int leadDim) {
            if (leadDim >= A.Dimensions.NumberOfDimensions)
                throw new ILArgumentException("dimension parameter out of range!");
            if (A.IsEmpty)       
                return  ILLogicalArray .empty(A.Dimensions); 
            if (A.IsScalar) {
                return new ILLogicalArray (new byte [1]{(A.GetValue(0).iszero())?(byte)0:(byte)1},1,1);
            }
            ILDimension inDim = A.Dimensions; 
			int[] newDims = inDim.ToIntArray();
            int tmpCount = 0; 
			int newLength;
			 byte [] retDblArr;
			// build ILDimension
			newLength = inDim.NumberOfElements / newDims[leadDim];
			newDims[leadDim] = 1;
			retDblArr = ILMemoryPool.Pool.New< byte >(newLength);
            ILDimension newDimension = new ILDimension(newDims); 
            int incOut = newDimension.SequentialIndexDistance(leadDim); 
            int leadDimLen = inDim[leadDim];
            int posCounter; 
			int nrHigherDims = inDim.NumberOfElements / leadDimLen;
            if (A.IsReference) {
#region Reference storage
				// ========================  REFERENCE double Storage ===========
				if (A.IsMatrix) {
#region Matrix
					////////////////////////////   MATRIX   ///////////////////////
					unsafe {
						ILIndexOffset idxOffset = A.m_indexOffset;
						int secDim = (leadDim + 1) % 2;
						fixed (int* leadDimStart = idxOffset[leadDim],
								secDimStart = idxOffset[secDim]) {
							fixed ( byte * pOutArr = retDblArr)
						    fixed ( complex * pInArr = A.m_data) {
								 byte * tmpOut = pOutArr;
								 byte * lastElementOut = tmpOut + retDblArr.Length;
								 complex * tmpIn = pInArr;
								int* secDimEnd = secDimStart + idxOffset[secDim].Length - 1;
								int* secDimIdx = secDimStart; 
								int* leadDimIdx = leadDimStart;
								int* leadDimEnd = leadDimStart + leadDimLen - 1;
								// start at first element
								while (secDimIdx <= secDimEnd) {
									tmpIn = pInArr + *secDimIdx++; 
									leadDimIdx = leadDimStart;
                                    
									while (leadDimIdx <= leadDimEnd) {
                                        complex inVal = *(tmpIn + *leadDimIdx++); 
                                        /**/
										 tmpCount +=  ( (inVal)  .iszero())?0:1; 
									}
                                    *tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; 
                                    tmpOut++;
								}
							}
						}
					} 
#endregion
				} else {
					/////////////////////////////   ARBITRARY DIMENSIONS //////////
#region arbitrary size
					unsafe {
						ILIndexOffset idxOffset = A.m_indexOffset;
						int[] curPosition = new int[A.Dimensions.NumberOfDimensions];
						fixed (int* leadDimStart = idxOffset[leadDim]) {
							fixed ( byte * pOutArr = retDblArr)
							fixed ( complex * pInArr = A.m_data) {
								 byte * tmpOut = pOutArr;
								 byte * lastElementOut = tmpOut + retDblArr.Length - 1;
								 complex * tmpIn = pInArr + A.m_indexOffset.Map(0);
								int* leadDimIdx = leadDimStart;
								int* leadDimEnd = leadDimStart + leadDimLen;
								int dimLen = curPosition.Length;
								int d, curD;
								// start at first element
                                posCounter = retDblArr.Length; 
								while (posCounter-->0) {
									leadDimIdx = leadDimStart;
                                    
									while (leadDimIdx < leadDimEnd){
                                        complex inVal = *(tmpIn + *leadDimIdx++); 
                                        /**/
										 tmpCount +=  ( (inVal)  .iszero())?0:1; 
                                    *tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; 
                                    }
                                    tmpOut += incOut;
                                    if (tmpOut > lastElementOut)
                                        tmpOut -= (retDblArr.Length - 1);
									// increment higher dimensions 
									d = 1;
									while (d < dimLen) {
										curD = (d + leadDim) % dimLen;
										curPosition[curD]++;
										if (curPosition[curD] < idxOffset[curD].Length) {
											break;
										}
										curPosition[curD] = 0;
										d++;
									}
                                    tmpIn = pInArr + A.m_indexOffset.IndexFromArray(curPosition); 
								}
							}
						}
					}
#endregion
				}
				// ==============================================================
#endregion
			} else {
				// physical -> pointer arithmetic
                if (leadDim == 0) {
#region physical along 1st leading dimension
                    unsafe {
                        fixed ( byte * pOutArr = retDblArr)
                        fixed ( complex * pInArr = A.m_data) {
                            complex * lastElement;
                            byte * tmpOut = pOutArr;
                            complex * tmpIn = pInArr;
                            for (int h = nrHigherDims; h-- > 0; ) {
								lastElement = tmpIn + leadDimLen;
                                
                                while (tmpIn < lastElement) {
                                    complex inVal = *(tmpIn++); 
                                    /**/
                                    tmpCount +=  ( (inVal)  .iszero())?0:1; 
                                }
                                *tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; 
                                tmpOut++;
                            }
                        }
					}
#endregion
				} else {
#region physical along abitrary dimension
					// sum along abitrary dimension 
                    unsafe {
                        fixed ( byte * pOutArr = retDblArr)
                        fixed ( complex * pInArr = A.m_data) {
                            byte * lastElementOut = newLength + pOutArr -1;
                            int inLength = inDim.NumberOfElements -1; 
                            complex * lastElementIn = pInArr + inLength; 
                            int inc = inDim.SequentialIndexDistance(leadDim); 
                            byte * tmpOut = pOutArr;
                            int outLength = newLength - 1;
                            complex * leadEnd; 
                            complex * tmpIn = pInArr;
                            for (int h = nrHigherDims; h--> 0; ) {
								leadEnd = tmpIn + leadDimLen * inc;
                                
                                while (tmpIn < leadEnd) {
                                    complex inVal = *(tmpIn); 
                                    tmpIn += inc; 
                                    /**/
                                    tmpCount +=  ( (inVal)  .iszero())?0:1; 
                                }
                                *tmpOut = (tmpCount == leadDimLen)? (byte)1:(byte)0; tmpCount = 0; 
                                tmpOut  += inc;
                                if (tmpOut > lastElementOut)
                                    tmpOut = pOutArr + ((tmpOut - pOutArr) - outLength);
                                if (tmpIn > lastElementIn)
                                    tmpIn = pInArr + ((tmpIn - pInArr) - inLength); 
                            }
                        }
					}
#endregion
				}
			}
			return new  ILLogicalArray (retDblArr, newDims);;
        }

#endregion HYCALPER AUTO GENERATED CODE
    }
}
