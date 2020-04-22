using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.warehouse
{
    /// <summary>
    /// 系统语言设置表
    /// </summary>
    [Table("wms_languages")]
    public class wms_languages
    {

        /// <summary>
        /// 自增主键
        /// </summary>
        [Key, Column(Order = 1)]
        public Int32 Id { get; set; }

        /// <summary>
        /// 关键字
        /// </summary>
        public String code { get; set; }

        /// <summary>
        /// 中文
        /// </summary>
        public String name { get; set; }

        /// <summary>
        /// 译文
        /// </summary>
        public String translation { get; set; }

        /// <summary>
        /// 语种：cn、en
        /// </summary>
        public String languages_type { get; set; }

        /// <summary>
        /// 使用类型：1后端,2前端
        /// </summary>
        public SByte use_type { get; set; }

    }
}