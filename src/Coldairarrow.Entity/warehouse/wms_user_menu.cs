using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.warehouse
{
    /// <summary>
    /// �û��˵�
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
        /// ϵͳ
        /// </summary>
        public Int32 us_id { get; set; }

        /// <summary>
        /// ϵͳ����
        /// </summary>
        public String um_system { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public String um_code { get; set; }

        /// <summary>
        /// 0Ϊ����
        /// </summary>
        public Int32 parent_id { get; set; }

        /// <summary>
        /// �û��˵�����
        /// </summary>
        public String um_title { get; set; }

        /// <summary>
        /// �˵�Ӣ������
        /// </summary>
        public String um_title_en { get; set; }

        /// <summary>
        /// �˵���������
        /// </summary>
        public String um_title_ru { get; set; }

        /// <summary>
        /// ̩��
        /// </summary>
        public String um_title_th { get; set; }

        /// <summary>
        /// URL
        /// </summary>
        public String um_url { get; set; }

        /// <summary>
        /// ��ʽ
        /// </summary>
        public String um_css { get; set; }

        /// <summary>
        /// um_color
        /// </summary>
        public String um_color { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public Int32 um_sort { get; set; }

        /// <summary>
        /// 0
        /// </summary>
        public SByte um_type { get; set; }

    }
}