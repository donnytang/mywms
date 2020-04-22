using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.warehouse
{
    /// <summary>
    /// 用户列表
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
        /// 登录名
        /// </summary>
        public String user_code { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public String user_password { get; set; }

        /// <summary>
        /// 真实姓名
        /// </summary>
        public String user_name { get; set; }

        /// <summary>
        /// 英文名
        /// </summary>
        public String user_name_en { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public SByte user_status { get; set; }

        /// <summary>
        /// 电子邮箱
        /// </summary>
        public String user_email { get; set; }

        /// <summary>
        /// 用户QQ号码
        /// </summary>
        public String user_qq { get; set; }

        /// <summary>
        /// 人员所属部门ID
        /// </summary>
        public Int32 ud_id { get; set; }

        /// <summary>
        /// 职位ID
        /// </summary>
        public Int32 p_id { get; set; }

        /// <summary>
        /// 角色ID
        /// </summary>
        public Int32 up_id { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public String user_phone { get; set; }

        /// <summary>
        /// 联系手机号
        /// </summary>
        public String user_mobile_phone { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public String user_note { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? user_add_time { get; set; }

        /// <summary>
        /// 最后登录时间
        /// </summary>
        public DateTime? user_last_login { get; set; }

        /// <summary>
        /// 最后更新时间
        /// </summary>
        public DateTime? user_update_time { get; set; }

    }
}