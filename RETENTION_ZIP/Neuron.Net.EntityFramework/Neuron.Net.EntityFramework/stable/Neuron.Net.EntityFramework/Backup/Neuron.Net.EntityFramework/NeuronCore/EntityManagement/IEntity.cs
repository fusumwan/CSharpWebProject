using System;
using System.Collections.Generic;
using System.Data;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-07-03>
///-- Description:	 NEURON .Net Entity Framework is developed by PHILIP FU in 2008. 
///--                This library is for relational object databases model class.
///-- =============================================


namespace NEURON.ENTITY.FRAMEWORK
{

    public interface IEntity<DBConnect> : IDisposable
    {
        void Init();
        bool Vaild(bool x_bInsert);
        bool GetFound();
        void SetFound(bool value);
        global::System.Data.DataTable GetTbl();
        void SetTbl(DataTable value);
        global::System.Data.DataRow GetRow();
        void SetRow(global::System.Data.DataRow value);
        DBConnect GetDB();
        void SetDB(DBConnect x_oObj);
        bool CheckNullable(string x_sColumnName);
        object GetRepositoryObject(object x_oObj);
        bool Save();
        bool Delete();
        void Release();
    }

}

