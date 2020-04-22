using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.warehouse
{
    /// <summary>
    /// 用户菜单
    /// </summary>
    [Table("wms_user_menu")]
    public class wms_user_menu
    {

        /// <summary>
        /// Id
        /// </summary>
        [Key, Column(Order = 1)]
        public Int32 Id { get; set; }

        /// <summary>
        /// 系统
        /// </summary>
        public Int32 us_id { get; set; }

        /// <summary>
        /// 系统代码
        /// </summary>
        public String um_system { get; set; }

        /// <summary>
        /// 代码
        /// </summary>
        public String um_code { get; set; }

        /// <summary>
        /// 0为顶级
        /// </summary>
        public Int32 parent_id { get; set; }

        /// <summary>
        /// 用户菜单名称
        /// </summary>
        public String um_title { get; set; }

        /// <summary>
        /// 菜单英文名称
        /// </summary>
        public String um_title_en { get; set; }

        /// <summary>
        /// 菜单俄文名称
        /// </summary>
        public String um_title_ru { get; set; }

        /// <summary>
        /// 泰文
        /// </summary>
        public String um_title_th { get; set; }

        /// <summary>
        /// URL
        /// </summary>
        public String um_url { get; set; }

        /// <summary>
        /// 样式
        /// </summary>
        public String um_css { get; set; }

        /// <summary>
        /// um_color
        /// </summary>
        public String um_color { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public Int32 um_sort { get; set; }

        /// <summary>
        /// 0
        /// </summary>
        public SByte um_type { get; set; }

    }
}