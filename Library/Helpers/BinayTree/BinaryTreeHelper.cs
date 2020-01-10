using Library.Helpers.BinayTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Helpers
{
    public class BinaryTreeHelper
    {
        #region 基础操作

        #endregion
        /// <summary>
        /// 初始化二叉树
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static BinaryTree InitTree(List<int?> array)
        {
            int index = 0;
            BinaryTree head = new BinaryTree(array[index].Value);
            array.RemoveAt(0);
            PeerBuild(array, new List<BinaryTree>() { head });
            return head;
        }

        /// <summary>
        /// 初始化叶子节点 -递归
        /// </summary>
        /// <param name="array"></param>
        /// <param name="parent"></param>
        private static void PeerBuild(List<int?> array, List<BinaryTree> parent)
        {
            if (parent.Count == 0 || parent == null || array.Count == 0)
                return;

            List<BinaryTree> newParent = new List<BinaryTree>();
            foreach (var item in parent)
            {
                if (array.Count != 0)
                {
                    if (array[0].HasValue)
                        item.left = new BinaryTree(array[0].Value);
                    array.RemoveAt(0);
                }
                if (array.Count != 0)
                {
                    if (array[0].HasValue)
                        item.right = new BinaryTree(array[0].Value);
                    array.RemoveAt(0);
                }
                newParent.Add(item == null ? item : item.left);
                newParent.Add(item == null ? item : item.right);
            }

            PeerBuild(array, newParent);
        }



        #region leetcode

        //路径和
        public static bool HasPath(BinaryTree root, int sum)
        {
            if (root == null)
                return false;
            if ((sum - root.val) == 0 && (root.left == null && root.right == null))
                return true;

            return HasPath(root.left, sum - root.val) || HasPath(root.right, sum - root.val);
        }

        #endregion
    }
}
