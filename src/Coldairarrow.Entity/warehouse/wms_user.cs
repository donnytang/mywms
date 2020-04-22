using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.warehouse
{
    /// <summary>
    /// �û��б�
    /// </summary>
    [Table("wms_user")]
    public class wms_user
    {

        /// <summary>
        /// ID
        /// </summary>
        [Key, Column(Order = 1)]
        public Int32 Id { get; set; }

        /// <summary>
        /// ��¼��
        /// </summary>
        public String user_code { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public String user_password { get; set; }

        /// <summary>
        /// ��ʵ����
        /// </summary>
        public String user_name { get; set; }

        /// <summary>
        /// Ӣ����
        /// </summary>
        public String user_name_en { get; set; }

        /// <summary>
        /// ״̬
        /// </summary>
        public SByte user_status { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public String user_email { get; set; }

        /// <summary>
        /// �û�QQ����
        /// </summary>
        public String user_qq { get; set; }

        /// <summary>
        /// ��Ա��������ID
        /// </summary>
        public Int32 ud_id { get; set; }

        /// <summary>
        /// ְλID
        /// </summary>
        public Int32 p_id { get; set; }

        /// <summary>
        /// ��ɫID
        /// </summary>
        public Int32 up_id { get; set; }

        /// <summary>
        /// ��ϵ�绰
        /// </summary>
        public String user_phone { get; set; }

        /// <summary>
        /// ��ϵ�ֻ���
        /// </summary>
        public String user_mobile_phone { get; set; }

        /// <summary>
        /// ��ע
        /// </summary>
        public String user_note { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime? user_add_time { get; set; }

        /// <summary>
        /// ����¼ʱ��
        /// </summary>
        public DateTime? user_last_login { get; set; }

        /// <summary>
        /// ������ʱ��
        /// </summary>
        public DateTime? user_update_time { get; set; }

    }
}