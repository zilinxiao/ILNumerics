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
using System.Runtime.InteropServices;
using ILNumerics.Storage;
using ILNumerics.Misc;
using ILNumerics;
using System.Security;

namespace ILNumerics.Native {
    
	/// <summary>
	/// LAPACK implementation for AMD processors
	/// </summary>
    /// <remarks>By using this module, you will have to make sure,
    /// you placed all runtime binaries for AMD's performance library 
    /// into the binary output dir accessable for ILNumerics.Net assemblies. 
    /// Those modules must be donwloaded seperately, since it is not 
    /// permitted to distribute them among with LGPL code. However, 
    /// developing and redistributing of products with ACML is possible though. 
    /// AMD currently does not charge money for a redistributable 
    /// license, given that one signs a license agreement with AMD 
    /// individually.</remarks>
    public class ILACML4_1 : IILLapack {

        #region constructor 
        public ILACML4_1 () {}
        #endregion

        #region DLL IMPORTS
        ////////////////////////////////////  DOUBLE LAPACK //////////////////
        [DllImport("libacml_dll", EntryPoint = "dgemm"),SuppressUnmanagedCodeSecurity]
		private static extern void acml_dgemm(char TransA, char TransB, int M, int N, int K, double alpha, IntPtr A, int lda, IntPtr B, int ldb, double beta, double[] C, int ldc);
        [DllImport("lapack_gen", EntryPoint = "zgemm"),SuppressUnmanagedCodeSecurity]
		private static extern void acml_zgemm(ref char TransA, ref char TransB, ref int M, ref int N, ref int K, ref complex alpha, IntPtr A, ref int lda, IntPtr B, ref int ldb, ref complex beta, [In, Out] complex[] C, ref int ldc);

        [DllImport("libacml_dll", EntryPoint = "dgesdd",CallingConvention = CallingConvention.StdCall)]
		private static extern void acml_dgesdd(char jobz, int m, int n, double[] a, int lda, double[] s, double[] u, int ldu, double[] vt, int ldvt, ref int info);
        [DllImport("libacml_dll", EntryPoint = "zgesdd"),SuppressUnmanagedCodeSecurity]
		private static extern void acml_zgesdd(char jobz, int m, int n, [In,Out] complex[] a, int lda, double[] s, [In,Out] complex[] u, int ldu, [In,Out] complex[] vt, int ldvt, ref int info);

        [DllImport("libacml_dll", EntryPoint = "dgesvd"),SuppressUnmanagedCodeSecurity]
		private static extern void acml_dgesvd(char jobu, char jobvt, int m, int n,  double[] a, int lda, double[] s, double[] u, int ldu, double[] vt, int ldvt, ref int info);
        [DllImport("libacml_dll", EntryPoint = "zgesvd"),SuppressUnmanagedCodeSecurity]
		private static extern void acml_zgesvd(char jobu, char jobvt, int m, int n, [In,Out] complex[] a, int lda, double[] s, [In,Out] complex[] u, int ldu, [In,Out] complex[] vt, int ldvt,  ref int info);
            
        [DllImport("libacml_dll", EntryPoint = "dpotrf"),SuppressUnmanagedCodeSecurity]
        private static extern void acml_dpotrf (char uplo, int n, double [] A, int lda, ref int info);
        [DllImport("libacml_dll", EntryPoint = "cpotrf"),SuppressUnmanagedCodeSecurity]
        private static extern void acml_zpotrf (char uplo, int n, [In,Out] complex [] A, int lda, ref int info);
        
        [DllImport("libacml_dll", EntryPoint = "dpotri"),SuppressUnmanagedCodeSecurity]
        private static extern void acml_dpotri (char uplo, int n, double [] A, int lda,ref int info);
        [DllImport("libacml_dll", EntryPoint = "zpotri"),SuppressUnmanagedCodeSecurity]
        private static extern void acml_zpotri (char uplo, int n, [In,Out] complex [] A, int lda,ref int info);

        [DllImport("libacml_dll", EntryPoint = "dpotrs"),SuppressUnmanagedCodeSecurity]
        private static extern void acml_dpotrs (char uplo, int n, int nrhs, double[] A, int lda, double[] B, int ldb, ref int info);
        [DllImport("libacml_dll", EntryPoint = "zpotrs"),SuppressUnmanagedCodeSecurity]
        private static extern void acml_zpotrs (char uplo, int n, int nrhs, [In,Out] complex[] A, int lda, [In,Out] complex[] B, int ldb, ref int info);

        [DllImport("libacml_dll", EntryPoint = "dgetrf"),SuppressUnmanagedCodeSecurity]
        private static extern void acml_dgetrf (int M, int N, double [] A, int LDA, int [] IPIV, ref int info);
        [DllImport("libacml_dll", EntryPoint = "zgetrf"),SuppressUnmanagedCodeSecurity]
        private static extern void acml_zgetrf (int M, int N, [In,Out] complex [] A, int LDA, int [] IPIV, ref int info);

        [DllImport("libacml_dll", EntryPoint = "dgetri"),SuppressUnmanagedCodeSecurity]
        private static extern void acml_dgetri (int N, double [] A, int LDA, int [] IPIV, ref int info);
        [DllImport("libacml_dll", EntryPoint = "zgetri"),SuppressUnmanagedCodeSecurity]
        private static extern void acml_zgetri (int N, [In,Out] complex [] A, int LDA, int [] IPIV, ref int info);

        [DllImport("libacml_dll", EntryPoint = "dgeqp3"),SuppressUnmanagedCodeSecurity]
        private static extern void acml_dgeqp3 (int M, int N, double [] A, int lda, int [] JPVT, double [] tau, ref int info);
        [DllImport("libacml_dll", EntryPoint = "zgeqp3"),SuppressUnmanagedCodeSecurity]
        private static extern void acml_zgeqp3 (int M, int N, [In,Out] complex [] A, int lda, int [] JPVT, [In,Out] complex [] tau, ref int info);
        
        [DllImport("libacml_dll", EntryPoint = "dgeqrf"),SuppressUnmanagedCodeSecurity]
        private static extern void acml_dgeqrf (int M, int N, double [] A, int lda, double [] tau, ref int info);
        [DllImport("libacml_dll", EntryPoint = "zgeqrf"),SuppressUnmanagedCodeSecurity]
        private static extern void acml_zgeqrf (int M, int N, [In,Out] complex [] A, int lda, [In,Out] complex[] tau, ref int info);

        [DllImport("libacml_dll", EntryPoint = "dormqr"),SuppressUnmanagedCodeSecurity]
        private static extern void acml_dormqr (char side, char trans, int m, int n, int k, double [] A, int lda, double [] tau , double [] C, int ldc, ref int info);
        
        [DllImport("libacml_dll", EntryPoint = "dorgqr"),SuppressUnmanagedCodeSecurity]
        private static extern void acml_dorgqr (int M, int N, int K, double [] A, int lda, double [] tau, ref int info);
        [DllImport("libacml_dll", EntryPoint = "zungqr"),SuppressUnmanagedCodeSecurity]
        private static extern void acml_zungqr (int M, int N, int K, [In,Out] complex  [] A, int lda, [In,Out] complex [] tau, ref int info);
        
        [DllImport("libacml_dll", EntryPoint = "dtrtrs"),SuppressUnmanagedCodeSecurity]
        private static extern void acml_dtrtrs (char uplo, char transA, char diag, int N, int nrhs, IntPtr A, int LDA, IntPtr B, int LDB, ref int info);
        [DllImport("libacml_dll", EntryPoint = "ztrtrs"),SuppressUnmanagedCodeSecurity]
        private static extern void acml_ztrtrs (char uplo, char transA, char diag, int N, int nrhs, IntPtr A, int LDA, IntPtr B, int LDB, ref int info);
        
        [DllImport("libacml_dll", EntryPoint = "dgetrs"),SuppressUnmanagedCodeSecurity]
        private static extern void acml_dgetrs (char trans, int N, int NRHS, double [] A, int LDA, int [] IPIV, double [] B, int LDB, ref int info); 
        [DllImport("libacml_dll", EntryPoint = "zgetrs"),SuppressUnmanagedCodeSecurity]
        private static extern void acml_zgetrs (char trans, int N, int NRHS, [In,Out] complex [] A, int LDA, int [] IPIV, [In,Out] complex [] B, int LDB, ref int info); 
        
        [DllImport("libacml_dll", EntryPoint = "dgelsd"),SuppressUnmanagedCodeSecurity]
        private static extern void acml_dgelsd (int m, int n, int nrhs, double[] A, int lda, double[] B, int ldb, double[] S, double RCond, ref int rank, ref int info); 
        [DllImport("libacml_dll", EntryPoint = "zgelsd"),SuppressUnmanagedCodeSecurity]
        private static extern void acml_zgelsd (int m, int n, int nrhs, [In,Out] complex[] A, int lda,[In,Out] complex[] B, int ldb, double[] S, double RCond, ref int rank, ref int info);  
        
        [DllImport("libacml_dll", EntryPoint = "dgelsy"),SuppressUnmanagedCodeSecurity]
        private static extern void acml_dgelsy (int m, int n, int nrhs, double[] A, int lda, double[] B, int ldb, int[] IPOV0, double RCond, ref int rank, ref int info); 
        [DllImport("libacml_dll", EntryPoint = "zgelsy"),SuppressUnmanagedCodeSecurity]
        private static extern void acml_zgelsy (int m, int n, int nrhs, [In,Out] complex[] A, int lda,[In,Out] complex[] B, int ldb, int[] IPOV0, double RCond, ref int rank, ref int info);  
        
        [DllImport("libacml_dll", EntryPoint = "dgeevx"),SuppressUnmanagedCodeSecurity]
        private static extern void acml_dgeevx (char balance, char jobvl, char jobvr, char sense, int n, double[] A, int lda, double[] wr, double[] wi, double[] vl, int ldvl, double[] vr, int ldvr, ref int ilo, ref int ihi, double[] scale, ref double abnrm, double[] rconde, double[] rcondv, ref int info); 
        [DllImport("libacml_dll", EntryPoint = "zgeevx"),SuppressUnmanagedCodeSecurity]
        private static extern void acml_zgeevx (char balance, char jobvl, char jobvr, char sense, int n, [In,Out] complex[] A, int lda, [In,Out] complex[] w, [In,Out] complex[] vl, int ldvl, [In,Out] complex[] vr, int ldvr, ref int ilo, ref int ihi, double[] scale, ref double abnrm, double[] rconde, double[] rcondv, ref int info);

        [DllImport("libacml_dll", EntryPoint = "dsyevr"),SuppressUnmanagedCodeSecurity]
        private static extern void acml_dsyevr (char jobz, char range, char uplo, int n, double  [] A, int lda, double vl, double vu, int il, int iu, double abstol, ref int m, double[] w, double  [] z, int ldz, int[] isuppz, ref int info); 
        [DllImport("libacml_dll", EntryPoint = "zheevr"),SuppressUnmanagedCodeSecurity]
        private static extern void acml_zheevr (char jobz, char range, char uplo, int n, [In,Out] complex [] A, int lda, double vl, double vu, int il, int iu, double abstol, ref int m, double[] w, [In,Out] complex [] z, int ldz, int[] isuppz, ref int info); 

        [DllImport("libacml_dll", EntryPoint = "dsygv"),SuppressUnmanagedCodeSecurity]
        private static extern void acml_dsygv (int itype, char jobz, char uplo, int n, double  [] A, int lda, double  [] B, int ldb, double [] w, ref int info); 
        [DllImport("libacml_dll", EntryPoint = "zhegv"),SuppressUnmanagedCodeSecurity]
        private static extern void acml_zhegv (int itype, char jobz, char uplo, int n, [In,Out] complex [] A, int lda, [In,Out] complex  [] B, int ldb, double [] w, ref int info); 


#endregion DLL_IMPORTS 

        #region IILLapack_INTERFACE
        public void dgemm(char TransA, char TransB, int M, int N, int K, double alpha, IntPtr A, int lda, IntPtr B, int ldb, double beta, double[] C, int ldc) {
            acml_dgemm(TransA, TransB, M, N, K, alpha, A, lda, B, ldb, beta, C, ldc);
        }
        public void zgemm(char TransA, char TransB, int M, int N, int K, complex alpha, IntPtr A, int lda, IntPtr B, int ldb, complex beta, complex[] C, int ldc) {
            acml_zgemm(ref TransA, ref TransB, ref M, ref N, ref K, ref alpha, A, ref lda, B, ref ldb, ref beta, C, ref ldc);
        }

        public void dgesdd(char jobz, int m, int n, double[] a, int lda, double[] s, double[] u, int ldu, double[] vt, int ldvt, ref int info) {
            acml_dgesdd(jobz, m, n, a, lda, s, u, ldu, vt, ldvt, ref info);
        }
        public void zgesdd(char jobz, int m, int n, complex[] a, int lda, double[] s, complex[] u, int ldu, complex[] vt, int ldvt, ref int info) {
            acml_zgesdd(jobz, m, n, a, lda, s, u, ldu, vt, ldvt, ref info);
        }

        public void dgesvd(char jobz, int m, int n, double[] a, int lda, double[] s, double[] u, int ldu, double[] vt, int ldvt, ref int info) {
            acml_dgesvd(jobz, jobz, m, n, a, lda, s, u, ldu, vt, ldvt, ref info);
        }
        public void zgesvd(char jobz, int m, int n, complex[] a, int lda, double[] s, complex[] u, int ldu, complex[] vt, int ldvt, ref int info) {
            acml_zgesvd(jobz, jobz, m, n, a, lda, s, u, ldu, vt, ldvt, ref info);
        }

        public void dpotrf(char uplo, int n, double[] A, int lda, ref int info) {
            acml_dpotrf(uplo,n, A, lda, ref info); 
        }
        public void zpotrf(char uplo, int n, complex[] A, int lda, ref int info) {
            acml_zpotrf(uplo,n, A, lda, ref info);
        }

        public void dpotri(char uplo, int n, double[] A, int lda, ref int info) {
            acml_dpotrf(uplo,n, A, lda, ref info); 
        }
        public void zpotri(char uplo, int n, complex[] A, int lda, ref int info) {
            acml_zpotrf(uplo,n, A, lda, ref info);
        }

        public void dgetrf(int M, int N, double[] A, int LDA, int[] IPIV, ref int info) {
            acml_dgetrf(M, N,  A, LDA, IPIV, ref info);
        }
        public void zgetrf(int M, int N, complex[] A, int LDA, int[] IPIV, ref int info) {
            acml_zgetrf(M, N,  A, LDA,  IPIV, ref info);
        }

        public void dgetri(int N, double[] A, int LDA, int[] IPIV, ref int info) {
            acml_dgetri(N, A, LDA, IPIV, ref info);
        }
        public void zgetri(int N, complex[] A, int LDA, int[] IPIV, ref int info) {
            acml_zgetri(N, A, LDA, IPIV, ref info);
        }

        public void dgeqrf(int M, int N, double[] A, int lda, double [] tau, ref int info) {
            acml_dgeqrf(M, N, A, lda, tau, ref info);
        }
        public void zgeqrf(int M, int N, complex[] A, int lda, complex [] tau, ref int info) {
            acml_zgeqrf(M, N, A, lda, tau, ref info);
        }

        public void dormqr(char side, char trans, int m, int n, int k, double [] A, int lda, double [] tau, double [] C, int ldc, ref int info) {
            acml_dormqr(side, trans, m,n,k, A, lda, tau, C,ldc, ref info);
        }

        public void dorgqr(int M, int N, int K, double[] A, int lda, double[] tau, ref int info) {
            acml_dorgqr(M,N,K,A,lda,tau,ref info); 
        }

        public void zungqr(int M, int N, int K, complex[] A, int lda, complex[] tau, ref int info) {
            acml_zungqr(M,N,K,A,lda,tau,ref info); 
        }

        public void dgeqp3 ( int M,int N,double [] A,int LDA,int [] JPVT,double [] tau,ref int info ) {
            acml_dgeqp3(M,N,A,LDA,JPVT,tau,ref info);
        }
        public void zgeqp3 ( int M,int N,complex [] A,int LDA,int [] JPVT,complex [] tau,ref int info ) {
            acml_zgeqp3(M,N,A,LDA,JPVT,tau,ref info);
        }

        public void dtrtrs(char uplo, char transA, char diag, int N, int nrhs, IntPtr A, int LDA, IntPtr B, int LDB, ref int info) {
            acml_dtrtrs (uplo, transA, diag, N, nrhs, A, LDA, B, LDB, ref info);
        }
        public void ztrtrs(char uplo, char transA, char diag, int N, int nrhs, IntPtr A, int LDA, IntPtr B, int LDB, ref int info) {
            acml_ztrtrs (uplo, transA, diag, N, nrhs, A, LDA, B, LDB, ref info);
        }

        public void dgetrs(char trans, int N, int NRHS, double[] A, int LDA, int[] IPIV, double[] B, int LDB, ref int info) {
            acml_dgetrs(trans,N,NRHS,A,LDA,IPIV,B,LDB,ref info); 
        }
        public void zgetrs(char trans, int N, int NRHS, complex[] A, int LDA, int[] IPIV, complex[] B, int LDB, ref int info) {
            acml_zgetrs(trans,N,NRHS,A,LDA,IPIV,B,LDB,ref info); 
        }

        public void dpotrs(char uplo, int n, int nrhs, double[] A, int lda, double[] B, int ldb, ref int info) {
            acml_dpotrs(uplo,n,nrhs,A,lda,B,ldb,ref info); 
        }
        public void zpotrs(char uplo, int n, int nrhs, complex[] A, int lda, complex[] B, int ldb, ref int info) {
            acml_zpotrs(uplo,n,nrhs,A,lda,B,ldb,ref info); 
        }
 
        public void dgelsd(int m, int n, int nrhs, double[] A, int lda, double[] B, int ldb, double[] S, double RCond, ref int rank, ref int info) {
            dgelsd (m, n, nrhs, A, lda, B, ldb, S, RCond, ref rank, ref info); 
        }
        public void zgelsd(int m, int n, int nrhs, complex[] A, int lda, complex[] B, int ldb, double[] S, double RCond, ref int rank, ref int info) {
            zgelsd (m, n, nrhs, A, lda, B, ldb, S, RCond, ref rank, ref info); 
        }

        public void dgelsy(int m, int n, int nrhs, double[] A, int lda, double[] B, int ldb, int[] JPVT0, double RCond, ref int rank, ref int info) {
            acml_dgelsy(m,n,nrhs,A,lda,B,ldb,JPVT0,RCond,ref rank,ref info); 
        }
        public void zgelsy(int m, int n, int nrhs, complex[] A, int lda, complex[] B, int ldb, int[] JPVT0, double RCond, ref int rank, ref int info) {
            acml_zgelsy(m,n,nrhs,A,lda,B,ldb,JPVT0,RCond,ref rank,ref info);
        }

        public void dgeevx(char balance, char jobvl, char jobvr, char sense, int n, double[] A, int lda, double[] wr, double[] wi, double[] vl, int ldvl, double[] vr, int ldvr, ref int ilo, ref int ihi, double[] scale, ref double abnrm, double[] rconde, double[] rcondv, ref int info) {
            acml_dgeevx(balance,jobvl,jobvr,sense,n,A,lda,wr,wi,vl,ldvl,vr,ldvr,ref ilo,ref ihi,scale,ref abnrm,rconde,rcondv,ref info); 
        }
        public void zgeevx(char balance, char jobvl, char jobvr, char sense, int n, complex[] A, int lda, complex[] w, complex[] vl, int ldvl, complex[] vr, int ldvr, ref int ilo, ref int ihi, double[] scale, ref double abnrm, double[] rconde, double[] rcondv, ref int info) {
            acml_zgeevx(balance,jobvl,jobvr,sense,n,A,lda,w,vl,ldvl,vr,ldvr,ref ilo,ref ihi,scale,ref abnrm,rconde,rcondv,ref info); 
        }

        public void dsyevr(char jobz, char range, char uplo, int n, double[] A, int lda, double vl, double vu, int il, int iu, double abstol, ref int m, double[] w, double[] z, int ldz, int[] isuppz, ref int info) {
            acml_dsyevr(jobz,range,uplo,n,A,lda,vl,vu,il,iu,abstol,ref m,w,z,ldz,isuppz,ref info); 
        }
        public void zheevr(char jobz, char range, char uplo, int n, complex[] A, int lda, double vl, double vu, int il, int iu, double abstol, ref int m, double[] w, complex[] z, int ldz, int[] isuppz, ref int info) {
            acml_zheevr(jobz,range,uplo,n,A,lda,vl,vu,il,iu,abstol,ref m,w,z,ldz,isuppz,ref info); 
        }

        // generalized eigenproblem: symmetric
        public void dsygv (int itype, char jobz, char uplo, int n, double  [] A, int lda, double  [] B, int ldb, double [] w, ref int info) {
            acml_dsygv (itype, jobz, uplo, n, A, lda, B, ldb, w, ref info); 
        }
        public void zhegv (int itype, char jobz, char uplo, int n, complex [] A, int lda, complex [] B, int ldb, double [] w, ref int info) { 
            acml_zhegv (itype, jobz, uplo, n, A, lda, B, ldb, w, ref info); 
        }

        #endregion
    }
}
