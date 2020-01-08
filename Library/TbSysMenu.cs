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
    /// �˵��ṹ��(sbt_sys_menu)�ı�����û���
    /// </summary>
    public class TbSysMenu : TbSysMenuBase
    {
        #region �û��ɱ༭����


        public   List<Tree> FindNext(string sMenuClass)
        {
            List<Tree> list = new List<Tree>();
            
           string sSQL = "select * from sbt_sys_menu where menu_class='"+sMenuClass+"' and level_num=1";
            DataSet ds = DataHelper.GetInstance("CenterCord").ExecuteDataSet(sSQL);
            
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Tree tb = new Tree();
                tb.Name = ds.Tables[0].Rows[i]["menu_name"].ToString();
                tb.Code = ds.Tables[0].Rows[i]["menu_code"].ToString();
                tb.Level =Convert.ToInt32( ds.Tables[0].Rows[i]["level_num"]);
                list.Add(tb);
            }

            return list;
        }


        public   List<Tree> FindChildAll(string sMenuCode)
        {
            List<Tree> list = new List<Tree>();

            string sSQL = "select * from sbt_sys_menu where parent_menu_code='" + sMenuCode+"'";
            DataSet ds = DataHelper.GetInstance("CenterCord").ExecuteDataSet(sSQL);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Tree tb = new Tree();
                tb.Name = ds.Tables[0].Rows[i]["menu_name"].ToString();
                tb.Code = ds.Tables[0].Rows[i]["menu_code"].ToString();
                tb.Level = Convert.ToInt32(ds.Tables[0].Rows[i]["level_num"]);
              
                list.Add(tb);
            }
            return list;
        }

            public static DataSet GetDataSetOfAll()
        {
            string sSQL = "select * from sbt_sys_menu order by list_order, menu_name";
            DataSet ds = DataHelper.Instance.ExecuteDataSet(sSQL);
            return ds;
        }
        /// ... Add your code here ... ///
        /// void FetchByXXX(...)
        /// static DataSet GetDataSetByXXX(...)
        /// static void DeleteByXXX(...)

        #endregion
    }


    /// <summary>
    /// �˵��ṹ��(sbt_sys_menu)���ֶ�����
    /// </summary>
    public class TbSysMenuF
    {
        public const string TableName = "sbt_sys_menu";
        public const string MenuCode = "menu_code";
        public const string MenuName = "menu_name";
        public const string MenuLink = "menu_link";
        public const string MenuClass = "menu_class";
        public const string MenuStyle = "menu_style";
        public const string MenuIcon = "menu_icon";
        public const string ParentMenuCode = "parent_menu_code";
        public const string LevelNum = "level_num";
        public const string ListOrder = "list_order";
        public const string IsActive = "is_active";
        public const string HasChild = "has_child";
        public const string IsMenuItem = "is_menu_item";
        public const string IsLogItem = "is_log_item";
        public const string IsRightItem = "is_right_item";
        public const string Remarks = "remarks";
    }


    /// <summary>
    /// �˵��ṹ��(sbt_sys_menu)�ı��������
    /// </summary>
    public class TbSysMenuBase : Sigbit.Data.TableBase
    {
        #region ˽�б�������
        protected string _menuCode = "";
        protected string _menuName = "";
        protected string _menuLink = "";
        protected string _menuClass = "";
        protected string _menuStyle = "";
        protected string _menuIcon = "";
        protected string _parentMenuCode = "";
        protected int _levelNum;
        protected int _listOrder;
        protected string _isActive = "";
        protected string _hasChild = "";
        protected string _isMenuItem = "";
        protected string _isLogItem = "";
        protected string _isRightItem = "";
        protected string _remarks = "";
        #endregion

        /// <summary>
        /// ���캯��
        /// </summary>
        public TbSysMenuBase()
        {
            ResetData();
        }

        #region ���Զ���
        /// <summary>
        /// �˵����룬����
        /// </summary>
        public string MenuCode
        {
            get
            {
                return _menuCode;
            }
            set
            {
                _menuCode = value;
            }
        }

        /// <summary>
        /// �˵�������
        /// </summary>
        public string MenuName
        {
            get
            {
                return _menuName;
            }
            set
            {
                _menuName = value;
            }
        }

        /// <summary>
        /// ҳ��URL
        /// </summary>
        public string MenuLink
        {
            get
            {
                return _menuLink;
            }
            set
            {
                _menuLink = value;
            }
        }

        /// <summary>
        /// �˵����
        /// </summary>
        public string MenuClass
        {
            get
            {
                return _menuClass;
            }
            set
            {
                _menuClass = value;
            }
        }

        /// <summary>
        /// �˵����
        /// </summary>
        public string MenuStyle
        {
            get
            {
                return _menuStyle;
            }
            set
            {
                _menuStyle = value;
            }
        }

        /// <summary>
        /// �˵���ͼ���ļ�
        /// </summary>
        public string MenuIcon
        {
            get
            {
                return _menuIcon;
            }
            set
            {
                _menuIcon = value;
            }
        }

        /// <summary>
        /// �ϼ��˵�����
        /// </summary>
        public string ParentMenuCode
        {
            get
            {
                return _parentMenuCode;
            }
            set
            {
                _parentMenuCode = value;
            }
        }

        /// <summary>
        /// ����λ��(��)����1ʼ
        /// </summary>
        public int LevelNum
        {
            get
            {
                return _levelNum;
            }
            set
            {
                _levelNum = value;
            }
        }

        /// <summary>
        /// ��������
        /// </summary>
        public int ListOrder
        {
            get
            {
                return _listOrder;
            }
            set
            {
                _listOrder = value;
            }
        }

        /// <summary>
        /// �Ƿ񼤻�(Y/N)
        /// </summary>
        public string IsActive
        {
            get
            {
                return _isActive;
            }
            set
            {
                _isActive = value;
            }
        }

        /// <summary>
        /// �Ƿ�������(Y/N)
        /// </summary>
        public string HasChild
        {
            get
            {
                return _hasChild;
            }
            set
            {
                _hasChild = value;
            }
        }

        /// <summary>
        /// �Ƿ�˵���
        /// </summary>
        public string IsMenuItem
        {
            get
            {
                return _isMenuItem;
            }
            set
            {
                _isMenuItem = value;
            }
        }

        /// <summary>
        /// �Ƿ���־��
        /// </summary>
        public string IsLogItem
        {
            get
            {
                return _isLogItem;
            }
            set
            {
                _isLogItem = value;
            }
        }

        /// <summary>
        /// �Ƿ�Ȩ����
        /// </summary>
        public string IsRightItem
        {
            get
            {
                return _isRightItem;
            }
            set
            {
                _isRightItem = value;
            }
        }

        /// <summary>
        /// ��ע
        /// </summary>
        public string Remarks
        {
            get
            {
                return _remarks;
            }
            set
            {
                _remarks = value;
            }
        }
        #endregion

        #region ���������㼰���
        /// <summary>
        /// �õ����ݵ�HTML��ʾ�ı�
        /// </summary>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("MenuCode: " + this._menuCode + "<br>");
            sb.Append("MenuName: " + this._menuName + "<br>");
            sb.Append("MenuLink: " + this._menuLink + "<br>");
            sb.Append("MenuClass: " + this._menuClass + "<br>");
            sb.Append("MenuStyle: " + this._menuStyle + "<br>");
            sb.Append("MenuIcon: " + this._menuIcon + "<br>");
            sb.Append("ParentMenuCode: " + this._parentMenuCode + "<br>");
            sb.Append("LevelNum: " + this._levelNum + "<br>");
            sb.Append("ListOrder: " + this._listOrder + "<br>");
            sb.Append("IsActive: " + this._isActive + "<br>");
            sb.Append("HasChild: " + this._hasChild + "<br>");
            sb.Append("IsMenuItem: " + this._isMenuItem + "<br>");
            sb.Append("IsLogItem: " + this._isLogItem + "<br>");
            sb.Append("IsRightItem: " + this._isRightItem + "<br>");
            sb.Append("Remarks: " + this._remarks + "<br>");
            return sb.ToString();
        }

        /// <summary>
        /// ���㱾��¼������
        /// </summary>
        public override void ResetData()
        {
            _menuCode = "";
            _menuName = "";
            _menuLink = "";
            _menuClass = "";
            _menuStyle = "";
            _menuIcon = "";
            _parentMenuCode = "";
            _levelNum = 0;
            _listOrder = 0;
            _isActive = "";
            _hasChild = "";
            _isMenuItem = "";
            _isLogItem = "";
            _isRightItem = "";
            _remarks = "";
        }

        #endregion

        #region ��������ɾ�Ĳ����
        /// <summary>
        /// ��������ȡһ�����ݣ��������������⣩
        /// </summary>
        public override void Fetch()
        {
            Fetch(false);
        }

        /// <summary>
        /// ��������ȡһ������
        /// </summary>
        /// <returns>�Ƿ���ʵ�����</returns>
        public override bool Fetch(bool allowNoData)
        {
            string sSQL;
            int nRecordCount;
            DataSet dataSet;
            DataRow row;

            //======= 1. �õ�SQL��� ==============
            sSQL = "select menu_name,           menu_link,           menu_class,           \n";
            sSQL += "       menu_style,          menu_icon,           parent_menu_code,     \n";
            sSQL += "       level_num,           list_order,          is_active,            \n";
            sSQL += "       has_child,           is_menu_item,        is_log_item,          \n";
            sSQL += "       is_right_item,       remarks              \n";
            sSQL += "  from sbt_sys_menu    \n";
            sSQL += "  where menu_code = " + Quote(_menuCode) + "\n";

            //======= 2. ����SQL��� ========
            dataSet = DataHelper.Instance.ExecuteDataSet(sSQL);
            nRecordCount = dataSet.Tables[0].Rows.Count;
            if (nRecordCount != 1)
            {
                if (!allowNoData)
                    throw new Exception("TbSysMenu.Fetch() Error - cannot locate record via PrimaryKey.");
                else
                    return false;
            }

            //======= 3. ��ȡ��¼ ========
            row = dataSet.Tables[0].Rows[0];
            _menuName = DbToString(row["menu_name"]);
            _menuLink = DbToString(row["menu_link"]);
            _menuClass = DbToString(row["menu_class"]);
            _menuStyle = DbToString(row["menu_style"]);
            _menuIcon = DbToString(row["menu_icon"]);
            _parentMenuCode = DbToString(row["parent_menu_code"]);
            _levelNum = DbToInt(row["level_num"]);
            _listOrder = DbToInt(row["list_order"]);
            _isActive = DbToString(row["is_active"]);
            _hasChild = DbToString(row["has_child"]);
            _isMenuItem = DbToString(row["is_menu_item"]);
            _isLogItem = DbToString(row["is_log_item"]);
            _isRightItem = DbToString(row["is_right_item"]);
            _remarks = DbToString(row["remarks"]);
            return true;
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        public override void Insert()
        {
            string sSQL;

            sSQL = "insert into sbt_sys_menu \n";
            sSQL += "( menu_code,        menu_name,        \n";
            sSQL += "  menu_link,        menu_class,       \n";
            sSQL += "  menu_style,       menu_icon,        \n";
            sSQL += "  parent_menu_code, level_num,        \n";
            sSQL += "  list_order,       is_active,        \n";
            sSQL += "  has_child,        is_menu_item,     \n";
            sSQL += "  is_log_item,      is_right_item,    \n";
            sSQL += "  remarks           \n";
            sSQL += ") values (          \n";
            sSQL += Quote(_menuCode) + "," + Quote(_menuName) + ",\n";
            sSQL += Quote(_menuLink) + "," + Quote(_menuClass) + ",\n";
            sSQL += Quote(_menuStyle) + "," + Quote(_menuIcon) + ",\n";
            sSQL += Quote(_parentMenuCode) + "," + _levelNum.ToString() + ",\n";
            sSQL += _listOrder.ToString() + "," + Quote(_isActive) + ",\n";
            sSQL += Quote(_hasChild) + "," + Quote(_isMenuItem) + ",\n";
            sSQL += Quote(_isLogItem) + "," + Quote(_isRightItem) + ",\n";
            sSQL += Quote(_remarks) + ")\n";

            DataHelper.Instance.ExecuteNonQuery(sSQL);
        }

        /// <summary>
        /// ������ɾ��һ������
        /// </summary>
        public override void Delete()
        {
            string sSQL;

            sSQL = "delete from sbt_sys_menu \n";
            sSQL += "  where menu_code = " + Quote(_menuCode) + "\n";

            int nRowsAffected;
            nRowsAffected = DataHelper.Instance.ExecuteNonQuery(sSQL);
            if (nRowsAffected != 1)
                throw new Exception("TbSysMenu.Delete() Error - cannot update data via PrimaryKey.");
        }

        /// <summary>
        /// ����������һ������
        /// </summary>
        public override void Update()
        {
            string sSQL;

            sSQL = "update sbt_sys_menu set \n";
            sSQL += " menu_code = " + Quote(_menuCode) + ",\n";
            sSQL += " menu_name = " + Quote(_menuName) + ",\n";
            sSQL += " menu_link = " + Quote(_menuLink) + ",\n";
            sSQL += " menu_class = " + Quote(_menuClass) + ",\n";
            sSQL += " menu_style = " + Quote(_menuStyle) + ",\n";
            sSQL += " menu_icon = " + Quote(_menuIcon) + ",\n";
            sSQL += " parent_menu_code = " + Quote(_parentMenuCode) + ",\n";
            sSQL += " level_num = " + _levelNum.ToString() + ",\n";
            sSQL += " list_order = " + _listOrder.ToString() + ",\n";
            sSQL += " is_active = " + Quote(_isActive) + ",\n";
            sSQL += " has_child = " + Quote(_hasChild) + ",\n";
            sSQL += " is_menu_item = " + Quote(_isMenuItem) + ",\n";
            sSQL += " is_log_item = " + Quote(_isLogItem) + ",\n";
            sSQL += " is_right_item = " + Quote(_isRightItem) + ",\n";
            sSQL += " remarks = " + Quote(_remarks) + "\n";
            sSQL += "  where menu_code = " + Quote(_menuCode) + "\n";

            int nRowsAffected;
            nRowsAffected = DataHelper.Instance.ExecuteNonQuery(sSQL);
            //if (nRowsAffected != 1)
            //    throw new Exception("TbSysMenu.Update() Error - cannot update data via PrimaryKey.");
        }

        /// <summary>
        /// �������жϼ�¼�Ƿ����
        /// </summary>
        /// <returns>��¼�Ƿ����</returns>
        public override bool RecordExists()
        {
            string sSQL;
            int nRecordCount;

            //======= 1. �õ�SQL��� ==============
            sSQL = "select count(*) from sbt_sys_menu \n";
            sSQL += "  where menu_code = " + Quote(_menuCode) + "\n";

            //======= 2. ����SQL��� ========
            nRecordCount = (int)DataHelper.Instance.ExecuteScalar(sSQL);
            if (nRecordCount == 1)
                return true;
            else
                return false;
        }

        #endregion

        #region ������Ϊ�����Ĳ���
        /// <summary>
        /// ������Ϊ������ȡһ�����ݣ��������������⣩
        /// </summary>
        public void FetchByE(string menuCode)
        {
            bool hasData;
            hasData = FetchBy(menuCode);
            if (!hasData)
                throw new Exception("TbSysMenu.FetchBy(...) Error - cannot locate record via PrimaryKey.");
        }

        /// <summary>
        /// ������Ϊ������ȡһ������
        /// </summary>
        /// <returns>�Ƿ���ʵ�����</returns>
        public bool FetchBy(string menuCode)
        {
            _menuCode = menuCode;

            return Fetch(true);
        }

        /// <summary>
        /// ������Ϊ������ȡ���ݣ����������ʵ��
        /// </summary>
        /// <returns>���ʵ��</returns>
        static public TbSysMenu CreateBy(string menuCode)
        {
            TbSysMenu tbl;
            bool hasData;

            tbl = new TbSysMenu();
            hasData = tbl.FetchBy(menuCode);

            if (!hasData)
                return null;
            else
                return tbl;
        }

        /// <summary>
        /// ������Ϊ����ɾ��һ������
        /// </summary>
        static public void DeleteBy(string menuCode)
        {
            TbSysMenu tbl;
            tbl = new TbSysMenu();

            tbl.MenuCode = menuCode;

            tbl.Delete();
        }

        #endregion

        #region �ļ��ͷ��������ص�֧�ֺ���
        /// <summary>
        /// ͨ��DataRow���и�ֵ
        /// </summary>
        public override void AssignByDataRow(DataRow row)
        {
            _menuCode = DbToString(row["menu_code"]);
            _menuName = DbToString(row["menu_name"]);
            _menuLink = DbToString(row["menu_link"]);
            _menuClass = DbToString(row["menu_class"]);
            _menuStyle = DbToString(row["menu_style"]);
            _menuIcon = DbToString(row["menu_icon"]);
            _parentMenuCode = DbToString(row["parent_menu_code"]);
            _levelNum = DbToInt(row["level_num"]);
            _listOrder = DbToInt(row["list_order"]);
            _isActive = DbToString(row["is_active"]);
            _hasChild = DbToString(row["has_child"]);
            _isMenuItem = DbToString(row["is_menu_item"]);
            _isLogItem = DbToString(row["is_log_item"]);
            _isRightItem = DbToString(row["is_right_item"]);
            _remarks = DbToString(row["remarks"]);
        }

        /// <summary>
        /// ͨ��DataSet���и�ֵ
        /// </summary>
        /// <param name="dataSet">���ݼ�</param>
        /// <param name="rowNum">�к�</param>
        public override void AssignByDataRow(DataSet dataSet, int rowNum)
        {
            DataRow row;
            row = dataSet.Tables[0].Rows[rowNum];

            AssignByDataRow(row);
        }

        /// <summary>
        /// ����ǰ��¼����Ϣ���浽�ļ�
        /// </summary>
        /// </param name="fileName">���浽���ļ���</param>
        public override void DumpToFile(string fileName)
        {
            //========= 1. ���ļ� ============
            StreamWriter writer;
            string sLine;
            writer = File.CreateText(fileName);

            //========= 2. д���ļ� ============
            sLine = "menu_code\x9" + _menuCode;
            writer.WriteLine(sLine);

            sLine = "menu_name\x9" + _menuName;
            writer.WriteLine(sLine);

            sLine = "menu_link\x9" + _menuLink;
            writer.WriteLine(sLine);

            sLine = "menu_class\x9" + _menuClass;
            writer.WriteLine(sLine);

            sLine = "menu_style\x9" + _menuStyle;
            writer.WriteLine(sLine);

            sLine = "menu_icon\x9" + _menuIcon;
            writer.WriteLine(sLine);

            sLine = "parent_menu_code\x9" + _parentMenuCode;
            writer.WriteLine(sLine);

            sLine = "level_num\x9" + _levelNum.ToString();
            writer.WriteLine(sLine);

            sLine = "list_order\x9" + _listOrder.ToString();
            writer.WriteLine(sLine);

            sLine = "is_active\x9" + _isActive;
            writer.WriteLine(sLine);

            sLine = "has_child\x9" + _hasChild;
            writer.WriteLine(sLine);

            sLine = "is_menu_item\x9" + _isMenuItem;
            writer.WriteLine(sLine);

            sLine = "is_log_item\x9" + _isLogItem;
            writer.WriteLine(sLine);

            sLine = "is_right_item\x9" + _isRightItem;
            writer.WriteLine(sLine);

            sLine = "remarks\x9" + _remarks;
            writer.WriteLine(sLine);

            //========= 3. �ر��ļ� ============
            writer.Flush();
            writer.Close();
        }

        /// <summary>
        /// �����е����м�¼���浽�ļ�
        /// </summary>
        /// </param name="fileName">���浽���ļ���</param>
        public override void DumpAllRecordsToFile(string fileName)
        {
            string sSQL;
            int i, nCol, nRecordCount;
            DataSet dataSet;
            DataRow row;
            string sFieldValue, sLine;
            StreamWriter writer;

            //======== 1. ���ļ� ========
            writer = File.CreateText(fileName);

            //======== 2. д���һ�У������У� ========
            sLine = "menu_code\tmenu_name\tmenu_link\t";
            sLine += "menu_class\tmenu_style\tmenu_icon\t";
            sLine += "parent_menu_code\tlevel_num\tlist_order\t";
            sLine += "is_active\thas_child\tis_menu_item\t";
            sLine += "is_log_item\tis_right_item\tremarks";
            writer.WriteLine(sLine);

            //======== 3. �õ�SQL��� ========
            sSQL = "select menu_code,       menu_name,       menu_link,       \n";
            sSQL += "       menu_class,      menu_style,      menu_icon,       \n";
            sSQL += "       parent_menu_code,level_num,       list_order,      \n";
            sSQL += "       is_active,       has_child,       is_menu_item,    \n";
            sSQL += "       is_log_item,     is_right_item,   remarks         \n";
            sSQL += "  from sbt_sys_menu";

            //======== 4. ����SQL��� ========
            dataSet = DataHelper.Instance.ExecuteDataSet(sSQL);
            nRecordCount = dataSet.Tables[0].Rows.Count;

            //======== 5. ����ÿһ�� ========
            for (i = 0; i < nRecordCount; i++)
            {
                row = dataSet.Tables[0].Rows[i];
                sLine = "";

                //======== 5.1 ����ÿһ�� ========
                for (nCol = 0; nCol < 15; nCol++)
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

                //======== 5.2 ��һ�е�ֵд���ļ� ========
                writer.WriteLine(sLine);
            }

            //======== 6. �ر��ļ� ========
            writer.Flush();
            writer.Close();
        }

        #endregion

        #region ����֧�ֺ���
        /// <summary>
        /// ��ȡһ���ֶε����ݿ�����
        /// </summary>
        static public string DBTypeOfFieldName(string fieldName)
        {
            switch (fieldName)
            {
                case "menu_code":
                    return "varchar";
                case "menu_name":
                    return "varchar";
                case "menu_link":
                    return "varchar";
                case "menu_class":
                    return "varchar";
                case "menu_style":
                    return "varchar";
                case "menu_icon":
                    return "varchar";
                case "parent_menu_code":
                    return "varchar";
                case "level_num":
                    return "int";
                case "list_order":
                    return "int";
                case "is_active":
                    return "varchar";
                case "has_child":
                    return "varchar";
                case "is_menu_item":
                    return "varchar";
                case "is_log_item":
                    return "varchar";
                case "is_right_item":
                    return "varchar";
                case "remarks":
                    return "varchar";
                default:
                    throw new Exception("TbSysMenuBase.DBTypeOfFieldName Error : meet unexpected fieldName - " + fieldName);
            }
        }

        /// <summary>
        /// ��ȡһ���ֶε�CSharp����
        /// </summary>
        static public string CSharpTypeOfFieldName(string fieldName)
        {
            switch (fieldName)
            {
                case "menu_code":
                    return "string";
                case "menu_name":
                    return "string";
                case "menu_link":
                    return "string";
                case "menu_class":
                    return "string";
                case "menu_style":
                    return "string";
                case "menu_icon":
                    return "string";
                case "parent_menu_code":
                    return "string";
                case "level_num":
                    return "int";
                case "list_order":
                    return "int";
                case "is_active":
                    return "string";
                case "has_child":
                    return "string";
                case "is_menu_item":
                    return "string";
                case "is_log_item":
                    return "string";
                case "is_right_item":
                    return "string";
                case "remarks":
                    return "string";
                default:
                    throw new Exception("TbSysMenuBase.CSharpTypeOfFieldName Error : meet unexpected fieldName - " + fieldName);
            }
        }

        /// <summary>
        /// ͨ��һ���ֶε�ֵ���ʵõ���һ���ֶε�ֵ
        /// </summary>
        static public string GetFieldValueBy(string fromFieldName, string fromFieldValue, string toFieldName)
        {
            string sSQL;
            int nRecordCount;
            DataSet dataSet;
            DataRow row;

            //======= 1. �õ�SQL��� ==============
            sSQL = "select " + toFieldName + "from sbt_sys_menu \n";
            sSQL += "where " + fromFieldName + " = ";
            if (CSharpTypeOfFieldName(fromFieldName) == "string")
                sSQL += "'" + fromFieldValue + "'";
            else
                sSQL += fromFieldValue;

            //======= 2. ����SQL��� ========
            dataSet = DataHelper.Instance.ExecuteDataSet(sSQL);
            nRecordCount = dataSet.Tables[0].Rows.Count;
            if (nRecordCount == 0)
                return "";

            //======= 3. ��ȡ��¼ ========
            row = dataSet.Tables[0].Rows[0];
            return row[toFieldName].ToString();
        }

        #endregion

    }
}
