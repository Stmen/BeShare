using System;
namespace CRDB.Model
{
	/// <summary>
	/// ʵ����crdb_urlrule ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class crdb_urlrule
	{
		public crdb_urlrule()
		{}
		#region Model
		private int _id;
		private string _article_url_pattern;
		private string _article_content_csspath;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string article_url_pattern
		{
			set{ _article_url_pattern=value;}
			get{return _article_url_pattern;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string article_content_csspath
		{
			set{ _article_content_csspath=value;}
			get{return _article_content_csspath;}
		}
		#endregion Model

	}
}

