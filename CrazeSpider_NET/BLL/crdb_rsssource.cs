using System;
using System.Data;
using System.Collections.Generic;
using LTP.Common;
using CRDB.Model;
namespace CRDB.BLL
{
	/// <summary>
	/// ҵ���߼���crdb_rsssource ��ժҪ˵����
	/// </summary>
	public class crdb_rsssource
	{
		private readonly CRDB.DAL.crdb_rsssource dal=new CRDB.DAL.crdb_rsssource();
		public crdb_rsssource()
		{}
		#region  ��Ա����

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int id)
		{
			return dal.Exists(id);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(CRDB.Model.crdb_rsssource model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(CRDB.Model.crdb_rsssource model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int id)
		{
			
			dal.Delete(id);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public CRDB.Model.crdb_rsssource GetModel(int id)
		{
			
			return dal.GetModel(id);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public CRDB.Model.crdb_rsssource GetModelByCache(int id)
		{
			
			string CacheKey = "crdb_rsssourceModel-" + id;
			object objModel = LTP.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(id);
					if (objModel != null)
					{
						int ModelCache = LTP.Common.ConfigHelper.GetConfigInt("ModelCache");
						LTP.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (CRDB.Model.crdb_rsssource)objModel;
		}
        public CRDB.Model.crdb_rsssource GetOneTask(string strWhere)
        {
            return dal.GetOneTask(strWhere);
        }
		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<CRDB.Model.crdb_rsssource> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<CRDB.Model.crdb_rsssource> DataTableToList(DataTable dt)
		{
			List<CRDB.Model.crdb_rsssource> modelList = new List<CRDB.Model.crdb_rsssource>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				CRDB.Model.crdb_rsssource model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new CRDB.Model.crdb_rsssource();
					if(dt.Rows[n]["id"].ToString()!="")
					{
						model.id=int.Parse(dt.Rows[n]["id"].ToString());
					}
					model.site_name=dt.Rows[n]["site_name"].ToString();
					model.site_code=dt.Rows[n]["site_code"].ToString();
					model.site_url=dt.Rows[n]["site_url"].ToString();
					model.article_url_pattern=dt.Rows[n]["article_url_pattern"].ToString();
					model.article_url_range=dt.Rows[n]["article_url_range"].ToString();
					if(dt.Rows[n]["gather_interval"].ToString()!="")
					{
						model.gather_interval=int.Parse(dt.Rows[n]["gather_interval"].ToString());
					}
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  ��Ա����
	}
}

