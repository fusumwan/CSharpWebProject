using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-06-07>
///-- Framework Description:	 NEURON .Net Entity Framework is developed by Sum Wan, FUin 2008. 
///--                            This library is for relational object databases model class.
///-- =============================================


namespace NEURON.ENTITY.FRAMEWORK{
    public class EntityFrameworkEnvironment
    {
        public IDictionary<Type, object> n_oAsset = new Dictionary<Type, object>();
        
        public EntityFrameworkEnvironment()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public void AssetModel(Type x_oType)
        {
            if (!n_oAsset.ContainsKey(x_oType))
            n_oAsset.Add(x_oType, null);
        }

        public void AssetRelease()
        {
            n_oAsset.Clear();
            n_oAsset = new Dictionary<Type, object>();
        }

        public T Model<T>()
        {
            if (n_oAsset.ContainsKey(typeof(T)))
            {
                if (n_oAsset[typeof(T)] == null)
                n_oAsset[typeof(T)] = (T)Activator.CreateInstance<T>();
                return (T)n_oAsset[typeof(T)];
            }
            return default(T);
        }

        public int GetAssetCount(){
            if (this.n_oAsset == null) return 0;
            return this.n_oAsset.Count;
        }

        public bool IsInitEnvironment()
        {
            if (n_oAsset.Count == 0) return false;
            return true;
        }
        public global::System.Security.Principal.IIdentity CurrentUser
        {
            get
            {
                return System.Threading.Thread.CurrentPrincipal.Identity;
            }
        }
    }
}

