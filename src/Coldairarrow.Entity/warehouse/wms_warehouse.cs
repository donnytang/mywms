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
        /// �ֿ����
        /// </summary>
        public String warehouse_code { get; set; }

        /// <summary>
        /// �ֿ�����
        /// </summary>
        public String warehouse_name { get; set; }

    }
}