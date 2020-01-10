using Sigbit.Net.CsvPacket;
using System.Collections.Generic;

namespace Library
{
    public class Menu
    {
        /// <summary>
        /// 树
        /// </summary>
        public List<Tree> Tree { get; set; }

        #region 树基本操作方法

        /// <summary>
        /// 获取菜单树
        /// </summary>
        /// <returns></returns>
        public List<Tree> GetMenuTree()
        {
            List<Tree> Menus = new List<Tree>();


            TbSysSubSystemDefine tb = new TbSysSubSystemDefine();
            List<TbSysSubSystemDefine> list = tb.FetchAll();

            foreach (var item in list)
            {
                Tree head = new Tree() { Level = 0, Name = item.SubSystemName, Code = "" };
                Menus.Add(head);


                TbSysMenu child = new TbSysMenu();
                List<Tree> level2 = child.FindNext(item.SubSystemId);
                head.Childs = level2;

                foreach (var item2 in head.Childs)
                {
                    item2.Childs = GetChildren(item2);
                }

            }
            return Menus;

        }

        /// <summary>
        /// 获取所有子菜单
        /// </summary>
        /// <param name="tb"></param>
        /// <returns></returns>
        public List<Tree> GetChildren(Tree tb)
        {
            List<Tree> menus = new List<Tree>();
            TbSysMenu child = new TbSysMenu();

            menus = child.FindChildAll(tb.Code);

            if (menus.Count == 0)
                return null;
            foreach (var item in menus)
            {
                item.Childs = GetChildren(item);
            }

            return menus;
        }

        #endregion

        #region 树解析转换

        /// <summary>
        /// 转为csv
        /// </summary>
        /// <param name="sSavePath"></param>
        public void ToCsv(string sSavePath)
        {
            CsvPacket csv = new CsvPacket();
            csv.AddField("head");
            csv.AddField("level1");
            csv.AddField("level2");
            csv.AddField("level3");

            int row = 1;
            int cloums = 1;
            foreach (var item in this.Tree)
            {
                csv.SetItemString(row, "head", item.Name);
                TranslateTreeChild(item, ref row, csv, cloums);
            }

            //Directory.GetCurrentDirectory() + "\\Menu.csv"
            csv.WriteToFile(sSavePath);
        }

        /// <summary>
        /// 转换子树
        /// </summary>
        /// <param name="menu"></param>
        /// <param name="row"></param>
        /// <param name="csv"></param>
        /// <param name="cloums"></param>
        private static void TranslateTreeChild(Tree menu, ref int row, CsvPacket csv, int cloums)
        {
            if (menu.Childs == null || menu.Childs.Count == 0)
                return;

            for (int i = 0; i < menu.Childs.Count; i++)
            {
                csv.SetItemString(row, "level" + cloums, menu.Childs[i].Name);
                int nextRow = row;
                TranslateTreeChild(menu.Childs[i], ref nextRow, csv, cloums + 1);
                if (nextRow > row)
                    row = nextRow;
                if (i != (menu.Childs.Count - 1))
                    row++;
            }

        }



        #endregion


    }



    /// <summary>
    /// 菜单树
    /// </summary>
    public class Tree
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string Code { get; set; }
        public List<Tree> Childs { get; set; }
    }


}
