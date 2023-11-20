using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-06-18>
///-- Description:	<Description,Class :IVasFilterObjEntityRepository, Data Repository Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    public interface IVasFilterObjEntityRepository<T> : IDisposable
    {
        #region Get & Set
        string GetNormal_rebate_type();
        string GetBundle_name();
        string GetRate_plan();
        string GetProgram();
        string GetVas_field();
        string GetHs_model();
        bool SetNormal_rebate_type(string value);
        bool SetBundle_name(string value);
        bool SetRate_plan(string value);
        bool SetProgram(string value);
        bool SetVas_field(string value);
        bool SetHs_model(string value);
        #endregion
        void Release();
        T DeepClone();

    }
}
