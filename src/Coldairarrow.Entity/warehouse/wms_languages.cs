using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.warehouse
{
    /// <summary>
    /// ϵͳ�������ñ�
    /// </summary>
    [Table("wms_languages")]
    public class wms_languages
    {

        /// <summary>
        /// ��������
        /// </summary>
        [Key, Column(Order = 1)]
        public Int32 Id { get; set; }

        /// <summary>
        /// �ؼ���
        /// </summary>
        public String code { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public String name { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public String translation { get; set; }

        /// <summary>
        /// ���֣�cn��en
        /// </summary>
        public String languages_type { get; set; }

        /// <summary>
        /// ʹ�����ͣ�1���,2ǰ��
        /// </summary>
        public SByte use_type { get; set; }

    }
}