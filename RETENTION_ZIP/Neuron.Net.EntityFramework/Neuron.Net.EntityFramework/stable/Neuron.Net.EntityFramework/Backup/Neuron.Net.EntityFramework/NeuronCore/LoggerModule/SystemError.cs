using System;
using System.Data;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;

///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-06-07>
///-- Description:	<SystemError Class!>
///-- =============================================

namespace NEURON.ENTITY.FRAMEWORK.CONNECT{
    public class SystemError
    {
        public static string m_fileName = "c:\\Systemlog.txt";
        public static String FileName
        {
            get
            {
                return (m_fileName);
            }
            set
            {
                if (value != null || value != "")
                {
                    m_fileName = value;
                }
            }
        }
        public void SetErrorFileNamePath(string strPath)
        {
            m_fileName = strPath;
        }
        public static void CreateErrorLog(string message)
        {
            /*
            if(File.Exists(m_fileName))
            {
                StreamWriter sr = File.AppendText(FileName);
                sr.WriteLine ("\n");
                sr.WriteLine (DateTime.Now.ToString()+message);
                sr.Close();
            }
            else
            {
                StreamWriter sr = File.CreateText(FileName);
                sr.Close();
            }
            */
        }
    }
}

