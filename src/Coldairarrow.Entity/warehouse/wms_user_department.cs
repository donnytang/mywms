using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.warehouse
{
    /// <summary>
    /// �û�����
    /// </summary>
    [Table("wms_user_department")]
    public class wms_user_department
    {

        /// <summary>
        /// Id
        /// </summary>
        [Key, Column(Order = 1)]
        public Int32 Id { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public String ud_name { get; set; }

        /// <summary>
        /// ����Ӣ������
        /// </summary>
        public String ud_name_en { get; set; }

        /// <summary>
        /// 0~999
        /// </summary>
        public SByte ud_sort { get; set; }

    }
}