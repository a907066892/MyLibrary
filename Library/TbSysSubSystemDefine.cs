using System;
using System.Data;
using System.Text;
using System.IO;

using Sigbit.Common;
using Sigbit.Data;
using System.Collections.Generic;

namespace Library
{
    /// <summary>
    /// 菜单结构表(sbt_sys_sub_system_define)的表操作用户类
    /// </summary>
    public class TbSysSubSystemDefine : TbSysSubSystemDefineBase
    {
        public override void Insert()
        {
            base.Insert();

       
        }

        public override void Update()
        {
            base.Update();

          
        }
        public override void Delete()
        {
            base.Delete();
          
        }


        public List<TbSysSubSystemDefine> FetchAll()
        {
            List<TbSysSubSystemDefine> list = new List<TbSysSubSystemDefine>();
            string sSQL = "select *  from sbt_sys_sub_system_define";
             
            //======= 2. 运行SQL语句 ========
            DataSet dataSet = DataHelper.GetInstance("CenterCord").ExecuteDataSet(sSQL);


            //======= 3. 读取记录 ========
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                TbSysSubSystemDefine tb = new TbSysSubSystemDefine();
                tb.AssignByDataRow(dataSet.Tables[0].Rows[i]);
                list.Add(tb);
            }

            return list;
        }
        public void UpdateIsActive(string sFullName)
        {
            string sSQL = "update sbt_sys_sub_system_define set is_active='N' where full_name = " + StringUtil.QuotedToDBStr(sFullName);
            DataHelper.Instance.ExecuteNonQuery(sSQL);
        }
    }
    /// <summary>
    /// 菜单结构表(sbt_sys_sub_system_define)的字段名类
    /// </summary>
    public class TbSysSubSystemDefineF
    {
        public const string TableName = "sbt_sys_sub_system_define";
        public const string SubSystemId = "sub_system_id";
        public const string SubSystemName = "sub_system_name";
        public const string SubSystemColor = "sub_system_color";
        public const string FullName = "full_name";
        public const string AppTheme = "app_theme";
        public const string HomepageGraph = "homepage_graph";
        public const string HomepageCaption = "homepage_caption";
        public const string HomepageLink = "homepage_link";
        public const string PageTitleText = "page_title_text";
        public const string PageTitleImage = "page_title_image";
        public const string MenuRootText = "menu_root_text";
        public const string DisplayOrder = "display_order";
        public const string IsActive = "is_active";
        public const string CreateTime = "create_time";
        public const string Creator = "creator";
        public const string ModifyTime = "modify_time";
        public const string Remarks = "remarks";
    }


    /// <summary>
    /// 菜单结构表(sbt_sys_sub_system_define)的表操作基类
    /// </summary>
    public class TbSysSubSystemDefineBase : Sigbit.Data.TableBase
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public TbSysSubSystemDefineBase()
        {
            ResetData();
        }

        #region 属性定义
        protected string _subSystemId = "";
        /// <summary>
        /// 子系统标识，主键
        /// </summary>
        public string SubSystemId
        {
            get { return _subSystemId; }
            set { _subSystemId = value; }
        }

        protected string _subSystemName = "";
        /// <summary>
        /// 子系统名称
        /// </summary>
        public string SubSystemName
        {
            get { return _subSystemName; }
            set { _subSystemName = value; }
        }

        protected string _subSystemColor = "";
        /// <summary>
        /// 代表的颜色值
        /// </summary>
        public string SubSystemColor
        {
            get { return _subSystemColor; }
            set { _subSystemColor = value; }
        }

        protected string _fullName = "";
        /// <summary>
        /// 全名
        /// </summary>
        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }

        protected string _appTheme = "";
        /// <summary>
        /// 主题
        /// </summary>
        public string AppTheme
        {
            get { return _appTheme; }
            set { _appTheme = value; }
        }

        protected string _homepageGraph = "";
        /// <summary>
        /// 首页上的图片名
        /// </summary>
        public string HomepageGraph
        {
            get { return _homepageGraph; }
            set { _homepageGraph = value; }
        }

        protected string _homepageCaption = "";
        /// <summary>
        /// 首页的子系统名称
        /// </summary>
        public string HomepageCaption
        {
            get { return _homepageCaption; }
            set { _homepageCaption = value; }
        }

        protected string _homepageLink = "";
        /// <summary>
        /// 首页跳转URL
        /// </summary>
        public string HomepageLink
        {
            get { return _homepageLink; }
            set { _homepageLink = value; }
        }

        protected string _pageTitleText = "";
        /// <summary>
        /// 主页标题上的文字
        /// </summary>
        public string PageTitleText
        {
            get { return _pageTitleText; }
            set { _pageTitleText = value; }
        }

        protected string _pageTitleImage = "";
        /// <summary>
        /// 主页标题上的图片文件
        /// </summary>
        public string PageTitleImage
        {
            get { return _pageTitleImage; }
            set { _pageTitleImage = value; }
        }

        protected string _menuRootText = "";
        /// <summary>
        /// 菜单根菜单的文字
        /// </summary>
        public string MenuRootText
        {
            get { return _menuRootText; }
            set { _menuRootText = value; }
        }

        protected int _displayOrder;
        /// <summary>
        /// 显示顺序
        /// </summary>
        public int DisplayOrder
        {
            get { return _displayOrder; }
            set { _displayOrder = value; }
        }

        protected string _isActive = "";
        /// <summary>
        /// 是否激活
        /// </summary>
        public string IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        protected string _createTime = "";
        /// <summary>
        /// 创建时间
        /// </summary>
        public string CreateTime
        {
            get { return _createTime; }
            set { _createTime = value; }
        }

        protected string _creator = "";
        /// <summary>
        /// 创建者
        /// </summary>
        public string Creator
        {
            get { return _creator; }
            set { _creator = value; }
        }

        protected string _modifyTime = "";
        /// <summary>
        /// 修改时间
        /// </summary>
        public string ModifyTime
        {
            get { return _modifyTime; }
            set { _modifyTime = value; }
        }

        protected string _remarks = "";
        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        }
        #endregion

        #region 变量的清零及输出
        /// <summary>
        /// 得到数据的HTML显示文本
        /// </summary>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("SubSystemId: " + this._subSystemId + "<br>");
            sb.Append("SubSystemName: " + this._subSystemName + "<br>");
            sb.Append("SubSystemColor: " + this._subSystemColor + "<br>");
            sb.Append("FullName: " + this._fullName + "<br>");
            sb.Append("AppTheme: " + this._appTheme + "<br>");
            sb.Append("HomepageGraph: " + this._homepageGraph + "<br>");
            sb.Append("HomepageCaption: " + this._homepageCaption + "<br>");
            sb.Append("HomepageLink: " + this._homepageLink + "<br>");
            sb.Append("PageTitleText: " + this._pageTitleText + "<br>");
            sb.Append("PageTitleImage: " + this._pageTitleImage + "<br>");
            sb.Append("MenuRootText: " + this._menuRootText + "<br>");
            sb.Append("DisplayOrder: " + this._displayOrder + "<br>");
            sb.Append("IsActive: " + this._isActive + "<br>");
            sb.Append("CreateTime: " + this._createTime + "<br>");
            sb.Append("Creator: " + this._creator + "<br>");
            sb.Append("ModifyTime: " + this._modifyTime + "<br>");
            sb.Append("Remarks: " + this._remarks + "<br>");
            return sb.ToString();
        }

        /// <summary>
        /// 清零本记录的数据
        /// </summary>
        public override void ResetData()
        {
            _subSystemId = "";
            _subSystemName = "";
            _subSystemColor = "";
            _fullName = "";
            _appTheme = "";
            _homepageGraph = "";
            _homepageCaption = "";
            _homepageLink = "";
            _pageTitleText = "";
            _pageTitleImage = "";
            _menuRootText = "";
            _displayOrder = 0;
            _isActive = "";
            _createTime = "";
            _creator = "";
            _modifyTime = "";
            _remarks = "";
        }
        #endregion

        #region 基本的增删改查操作
        /// <summary>
        /// 按主键获取一条数据（如无数据抛例外）
        /// </summary>
        public override void Fetch()
        {
            Fetch(false);
        }

        /// <summary>
        /// 按主键获取一条数据
        /// </summary>
        /// <returns>是否访问到数据</returns>
        public override bool Fetch(bool allowNoData)
        {
            string sSQL;
            int nRecordCount;
            DataSet dataSet;
            DataRow row;

            //======= 1. 得到SQL语句 ==============
            sSQL = "select sub_system_name,     sub_system_color,    full_name,            \r\n";
            sSQL += "       app_theme,           homepage_graph,      homepage_caption,     \r\n";
            sSQL += "       homepage_link,       page_title_text,     page_title_image,     \r\n";
            sSQL += "       menu_root_text,      display_order,       is_active,            \r\n";
            sSQL += "       create_time,         creator,             modify_time,          \r\n";
            sSQL += "       remarks              \r\n";
            sSQL += "  from sbt_sys_sub_system_define    \r\n";
            sSQL += "  where sub_system_id = " + Quote(_subSystemId) + "\r\n";

            //======= 2. 运行SQL语句 ========
            dataSet = DataHelper.Instance.ExecuteDataSet(sSQL);
            nRecordCount = dataSet.Tables[0].Rows.Count;
            if (nRecordCount != 1)
            {
                if (!allowNoData)
                    throw new Exception("TbSysSubSystemDefine.Fetch() Error - cannot locate record via PrimaryKey.");
                else
                    return false;
            }

            //======= 3. 读取记录 ========
            row = dataSet.Tables[0].Rows[0];
            _subSystemName = DbToString(row["sub_system_name"]);
            _subSystemColor = DbToString(row["sub_system_color"]);
            _fullName = DbToString(row["full_name"]);
            _appTheme = DbToString(row["app_theme"]);
            _homepageGraph = DbToString(row["homepage_graph"]);
            _homepageCaption = DbToString(row["homepage_caption"]);
            _homepageLink = DbToString(row["homepage_link"]);
            _pageTitleText = DbToString(row["page_title_text"]);
            _pageTitleImage = DbToString(row["page_title_image"]);
            _menuRootText = DbToString(row["menu_root_text"]);
            _displayOrder = DbToInt(row["display_order"]);
            _isActive = DbToString(row["is_active"]);
            _createTime = DbToString(row["create_time"]);
            _creator = DbToString(row["creator"]);
            _modifyTime = DbToString(row["modify_time"]);
            _remarks = DbToString(row["remarks"]);
            return true;
        }

        /// <summary>
        /// 插入一条数据
        /// </summary>
        public override void Insert()
        {
            string sSQL;

            sSQL = "insert into sbt_sys_sub_system_define \r\n";
            sSQL += "( sub_system_id,    sub_system_name,  \r\n";
            sSQL += "  sub_system_color, full_name,        \r\n";
            sSQL += "  app_theme,        homepage_graph,   \r\n";
            sSQL += "  homepage_caption, homepage_link,    \r\n";
            sSQL += "  page_title_text,  page_title_image, \r\n";
            sSQL += "  menu_root_text,   display_order,    \r\n";
            sSQL += "  is_active,        create_time,      \r\n";
            sSQL += "  creator,          modify_time,      \r\n";
            sSQL += "  remarks           \r\n";
            sSQL += ") values (          \r\n";
            sSQL += Quote(_subSystemId) + "," + Quote(_subSystemName) + ",\r\n";
            sSQL += Quote(_subSystemColor) + "," + Quote(_fullName) + ",\r\n";
            sSQL += Quote(_appTheme) + "," + Quote(_homepageGraph) + ",\r\n";
            sSQL += Quote(_homepageCaption) + "," + Quote(_homepageLink) + ",\r\n";
            sSQL += Quote(_pageTitleText) + "," + Quote(_pageTitleImage) + ",\r\n";
            sSQL += Quote(_menuRootText) + "," + _displayOrder.ToString() + ",\r\n";
            sSQL += Quote(_isActive) + "," + Quote(_createTime) + ",\r\n";
            sSQL += Quote(_creator) + "," + Quote(_modifyTime) + ",\r\n";
            sSQL += Quote(_remarks) + ")\r\n";

            DataHelper.Instance.ExecuteNonQuery(sSQL);
        }

        /// <summary>
        /// 按主键删除一条数据
        /// </summary>
        public override void Delete()
        {
            string sSQL;

            sSQL = "delete from sbt_sys_sub_system_define \r\n";
            sSQL += "  where sub_system_id = " + Quote(_subSystemId) + "\r\n";

            int nRowsAffected;
            nRowsAffected = DataHelper.Instance.ExecuteNonQuery(sSQL);
            //if (nRowsAffected != 1)
            //throw new Exception("TbSysSubSystemDefine.Delete() Error - cannot update data via PrimaryKey.");
        }

        /// <summary>
        /// 按主键更新一条数据
        /// </summary>
        public override void Update()
        {
            string sSQL;

            sSQL = "update sbt_sys_sub_system_define set \r\n";
            sSQL += " sub_system_id = " + Quote(_subSystemId) + ",\r\n";
            sSQL += " sub_system_name = " + Quote(_subSystemName) + ",\r\n";
            sSQL += " sub_system_color = " + Quote(_subSystemColor) + ",\r\n";
            sSQL += " full_name = " + Quote(_fullName) + ",\r\n";
            sSQL += " app_theme = " + Quote(_appTheme) + ",\r\n";
            sSQL += " homepage_graph = " + Quote(_homepageGraph) + ",\r\n";
            sSQL += " homepage_caption = " + Quote(_homepageCaption) + ",\r\n";
            sSQL += " homepage_link = " + Quote(_homepageLink) + ",\r\n";
            sSQL += " page_title_text = " + Quote(_pageTitleText) + ",\r\n";
            sSQL += " page_title_image = " + Quote(_pageTitleImage) + ",\r\n";
            sSQL += " menu_root_text = " + Quote(_menuRootText) + ",\r\n";
            sSQL += " display_order = " + _displayOrder.ToString() + ",\r\n";
            sSQL += " is_active = " + Quote(_isActive) + ",\r\n";
            sSQL += " create_time = " + Quote(_createTime) + ",\r\n";
            sSQL += " creator = " + Quote(_creator) + ",\r\n";
            sSQL += " modify_time = " + Quote(_modifyTime) + ",\r\n";
            sSQL += " remarks = " + Quote(_remarks) + "\r\n";
            sSQL += "  where sub_system_id = " + Quote(_subSystemId) + "\r\n";

            int nRowsAffected;
            nRowsAffected = DataHelper.Instance.ExecuteNonQuery(sSQL);
            //if (nRowsAffected > 1)
            //throw new Exception("TbSysSubSystemDefine.Update() Error - cannot update data via PrimaryKey.");
        }

        /// <summary>
        /// 按主键判断记录是否存在
        /// </summary>
        /// <returns>记录是否存在</returns>
        public override bool RecordExists()
        {
            string sSQL;
            int nRecordCount;

            //======= 1. 得到SQL语句 ==============
            sSQL = "select count(*) from sbt_sys_sub_system_define \r\n";
            sSQL += "  where sub_system_id = " + Quote(_subSystemId) + "\r\n";

            //======= 2. 运行SQL语句 ========
            nRecordCount = Convert.ToInt32(DataHelper.Instance.ExecuteScalar(sSQL));
            if (nRecordCount == 1)
                return true;
            else
                return false;
        }
        #endregion

        #region 以主键为参数的操作
        /// <summary>
        /// 以主键为参数获取一条数据（如无数据抛例外）
        /// </summary>
        public void FetchByE(string subSystemId)
        {
            bool hasData;
            hasData = FetchBy(subSystemId);
            if (!hasData)
                throw new Exception("TbSysSubSystemDefine.FetchBy(...) Error - cannot locate record via PrimaryKey.");
        }

        /// <summary>
        /// 以主键为参数获取一条数据
        /// </summary>
        /// <returns>是否访问到数据</returns>
        public bool FetchBy(string subSystemId)
        {
            _subSystemId = subSystemId;

            return Fetch(true);
        }

        /// <summary>
        /// 以主键为参数获取数据，并创建类的实例
        /// </summary>
        /// <returns>类的实例</returns>
        static public TbSysSubSystemDefine CreateBy(string subSystemId)
        {
            TbSysSubSystemDefine tbl;
            bool hasData;

            tbl = new TbSysSubSystemDefine();
            hasData = tbl.FetchBy(subSystemId);

            if (!hasData)
                return null;
            else
                return tbl;
        }

        /// <summary>
        /// 以主键为参数删除一条数据
        /// </summary>
        static public void DeleteBy(string subSystemId)
        {
            TbSysSubSystemDefine tbl;
            tbl = new TbSysSubSystemDefine();

            tbl.SubSystemId = subSystemId;

            tbl.Delete();
        }
        #endregion

        #region 文件和访问组件相关的支持函数
        /// <summary>
        /// 通过DataRow进行赋值
        /// </summary>
        public override void AssignByDataRow(DataRow row)
        {
            _subSystemId = DbToString(row["sub_system_id"]);
            _subSystemName = DbToString(row["sub_system_name"]);
            _subSystemColor = DbToString(row["sub_system_color"]);
            _fullName = DbToString(row["full_name"]);
            _appTheme = DbToString(row["app_theme"]);
            _homepageGraph = DbToString(row["homepage_graph"]);
            _homepageCaption = DbToString(row["homepage_caption"]);
            _homepageLink = DbToString(row["homepage_link"]);
            _pageTitleText = DbToString(row["page_title_text"]);
            _pageTitleImage = DbToString(row["page_title_image"]);
            _menuRootText = DbToString(row["menu_root_text"]);
            _displayOrder = DbToInt(row["display_order"]);
            _isActive = DbToString(row["is_active"]);
            _createTime = DbToString(row["create_time"]);
            _creator = DbToString(row["creator"]);
            _modifyTime = DbToString(row["modify_time"]);
            _remarks = DbToString(row["remarks"]);
        }

        /// <summary>
        /// 通过DataSet进行赋值
        /// </summary>
        /// <param name="dataSet">数据集</param>
        /// <param name="rowNum">行号</param>
        public override void AssignByDataRow(DataSet dataSet, int rowNum)
        {
            DataRow row;
            row = dataSet.Tables[0].Rows[rowNum];

            AssignByDataRow(row);
        }

        /// <summary>
        /// 将当前记录的信息保存到文件
        /// </summary>
        /// </param name="fileName">保存到的文件名</param>
        public override void DumpToFile(string fileName)
        {
            //========= 1. 打开文件 ============
            StreamWriter writer;
            string sLine;
            writer = File.CreateText(fileName);

            //========= 2. 写入文件 ============
            sLine = "sub_system_id\x9" + _subSystemId;
            writer.WriteLine(sLine);

            sLine = "sub_system_name\x9" + _subSystemName;
            writer.WriteLine(sLine);

            sLine = "sub_system_color\x9" + _subSystemColor;
            writer.WriteLine(sLine);

            sLine = "full_name\x9" + _fullName;
            writer.WriteLine(sLine);

            sLine = "app_theme\x9" + _appTheme;
            writer.WriteLine(sLine);

            sLine = "homepage_graph\x9" + _homepageGraph;
            writer.WriteLine(sLine);

            sLine = "homepage_caption\x9" + _homepageCaption;
            writer.WriteLine(sLine);

            sLine = "homepage_link\x9" + _homepageLink;
            writer.WriteLine(sLine);

            sLine = "page_title_text\x9" + _pageTitleText;
            writer.WriteLine(sLine);

            sLine = "page_title_image\x9" + _pageTitleImage;
            writer.WriteLine(sLine);

            sLine = "menu_root_text\x9" + _menuRootText;
            writer.WriteLine(sLine);

            sLine = "display_order\x9" + _displayOrder.ToString();
            writer.WriteLine(sLine);

            sLine = "is_active\x9" + _isActive;
            writer.WriteLine(sLine);

            sLine = "create_time\x9" + _createTime;
            writer.WriteLine(sLine);

            sLine = "creator\x9" + _creator;
            writer.WriteLine(sLine);

            sLine = "modify_time\x9" + _modifyTime;
            writer.WriteLine(sLine);

            sLine = "remarks\x9" + _remarks;
            writer.WriteLine(sLine);

            //========= 3. 关闭文件 ============
            writer.Flush();
            writer.Close();
        }

        /// <summary>
        /// 将表中的所有记录保存到文件
        /// </summary>
        /// </param name="fileName">保存到的文件名</param>
        public override void DumpAllRecordsToFile(string fileName)
        {
            string sSQL;
            int i, nCol, nRecordCount;
            DataSet dataSet;
            DataRow row;
            string sFieldValue, sLine;
            StreamWriter writer;

            //======== 1. 打开文件 ========
            writer = File.CreateText(fileName);

            //======== 2. 写入第一行（标题行） ========
            sLine = "sub_system_id\tsub_system_name\tsub_system_color\t";
            sLine += "full_name\tapp_theme\thomepage_graph\t";
            sLine += "homepage_caption\thomepage_link\tpage_title_text\t";
            sLine += "page_title_image\tmenu_root_text\tdisplay_order\t";
            sLine += "is_active\tcreate_time\tcreator\t";
            sLine += "modify_time\tremarks";
            writer.WriteLine(sLine);

            //======== 3. 得到SQL语句 ========
            sSQL = "select sub_system_id,   sub_system_name, sub_system_color,\r\n";
            sSQL += "       full_name,       app_theme,       homepage_graph,  \r\n";
            sSQL += "       homepage_caption,homepage_link,   page_title_text, \r\n";
            sSQL += "       page_title_image,menu_root_text,  display_order,   \r\n";
            sSQL += "       is_active,       create_time,     creator,         \r\n";
            sSQL += "       modify_time,     remarks         \r\n";
            sSQL += "  from sbt_sys_sub_system_define";

            //======== 4. 运行SQL语句 ========
            dataSet = DataHelper.Instance.ExecuteDataSet(sSQL);
            nRecordCount = dataSet.Tables[0].Rows.Count;

            //======== 5. 处理每一行 ========
            for (i = 0; i < nRecordCount; i++)
            {
                row = dataSet.Tables[0].Rows[i];
                sLine = "";

                //======== 5.1 处理每一列 ========
                for (nCol = 0; nCol < 17; nCol++)
                {
                    if (row[nCol] is DBNull)
                        sFieldValue = "";
                    else
                        sFieldValue = row[nCol].ToString();

                    if (nCol == 0)
                        sLine += sFieldValue;
                    else
                        sLine += "\t" + sFieldValue;
                }

                //======== 5.2 将一行的值写入文件 ========
                writer.WriteLine(sLine);
            }

            //======== 6. 关闭文件 ========
            writer.Flush();
            writer.Close();
        }
        #endregion

        #region 辅助支持函数
        /// <summary>
        /// 获取一个字段的数据库类型
        /// </summary>
        static public string DBTypeOfFieldName(string fieldName)
        {
            switch (fieldName)
            {
                case "sub_system_id":
                    return "varchar";
                case "sub_system_name":
                    return "varchar";
                case "sub_system_color":
                    return "varchar";
                case "full_name":
                    return "varchar";
                case "app_theme":
                    return "varchar";
                case "homepage_graph":
                    return "varchar";
                case "homepage_caption":
                    return "varchar";
                case "homepage_link":
                    return "varchar";
                case "page_title_text":
                    return "varchar";
                case "page_title_image":
                    return "varchar";
                case "menu_root_text":
                    return "varchar";
                case "display_order":
                    return "int";
                case "is_active":
                    return "char";
                case "create_time":
                    return "varchar";
                case "creator":
                    return "varchar";
                case "modify_time":
                    return "varchar";
                case "remarks":
                    return "varchar";
                default:
                    throw new Exception("TbSysSubSystemDefineBase.DBTypeOfFieldName Error : meet unexpected fieldName - " + fieldName);
            }
        }

        /// <summary>
        /// 获取一个字段的CSharp类型
        /// </summary>
        static public string CSharpTypeOfFieldName(string fieldName)
        {
            switch (fieldName)
            {
                case "sub_system_id":
                    return "string";
                case "sub_system_name":
                    return "string";
                case "sub_system_color":
                    return "string";
                case "full_name":
                    return "string";
                case "app_theme":
                    return "string";
                case "homepage_graph":
                    return "string";
                case "homepage_caption":
                    return "string";
                case "homepage_link":
                    return "string";
                case "page_title_text":
                    return "string";
                case "page_title_image":
                    return "string";
                case "menu_root_text":
                    return "string";
                case "display_order":
                    return "int";
                case "is_active":
                    return "string";
                case "create_time":
                    return "string";
                case "creator":
                    return "string";
                case "modify_time":
                    return "string";
                case "remarks":
                    return "string";
                default:
                    throw new Exception("TbSysSubSystemDefineBase.CSharpTypeOfFieldName Error : meet unexpected fieldName - " + fieldName);
            }
        }

        /// <summary>
        /// 通过一个字段的值访问得到另一个字段的值
        /// </summary>
        static public string GetFieldValueBy(string fromFieldName, string fromFieldValue, string toFieldName)
        {
            string sSQL;
            int nRecordCount;
            DataSet dataSet;
            DataRow row;

            //======= 1. 得到SQL语句 ==============
            sSQL = "select " + toFieldName + " from sbt_sys_sub_system_define \r\n";
            sSQL += "where " + fromFieldName + " = ";
            if (CSharpTypeOfFieldName(fromFieldName) == "string")
                sSQL += "'" + fromFieldValue + "'";
            else
                sSQL += fromFieldValue;

            //======= 2. 运行SQL语句 ========
            dataSet = DataHelper.Instance.ExecuteDataSet(sSQL);
            nRecordCount = dataSet.Tables[0].Rows.Count;
            if (nRecordCount == 0)
                return "";

            //======= 3. 读取记录 ========
            row = dataSet.Tables[0].Rows[0];
            return row[toFieldName].ToString();
        }
        #endregion
    }
}
