using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.warehouse
{
    /// <summary>
    /// wms_warehouse
    /// </summary>
    [Table("wms_warehouse")]
    public class wms_warehouse
    {

        /// <summary>
        /// Id
        /// </summary>
        [Key, Column(Order = 1)]
        public Int32 Id { get; set; }

        /// <summary>
        /// ²Ö¿â´úÂë
        /// </summary>
        public String warehouse_code { get; set; }

        /// <summary>
        /// ²Ö¿âÃû³Æ
        /// </summary>
        public String warehouse_name { get; set; }

    }
}