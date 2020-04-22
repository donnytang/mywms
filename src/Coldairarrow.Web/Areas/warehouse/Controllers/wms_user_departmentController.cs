using Coldairarrow.Business.warehouse;
using Coldairarrow.Entity.warehouse;
using Coldairarrow.Util;
using System;
using System.Web.Mvc;

namespace Coldairarrow.Web
{
    public class wms_user_departmentController : BaseMvcController
    {
        wms_user_departmentBusiness _wms_user_departmentBusiness = new wms_user_departmentBusiness();

        #region 视图功能

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form(int id = 0)
        {
            var theData = id == 0 ? new wms_user_department() : _wms_user_departmentBusiness.GetTheData(id);

            return View(theData);
        }

        #endregion

        #region 获取数据

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="condition">查询类型</param>
        /// <param name="keyword">关键字</param>
        /// <returns></returns>
        public ActionResult GetDataList(string condition, string keyword, Pagination pagination)
        {
            var dataList = _wms_user_departmentBusiness.GetDataList(condition, keyword, pagination);

            return Content(pagination.BuildTableResult_DataGrid(dataList).ToJson());
        }

        #endregion

        #region 提交数据

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="theData">保存的数据</param>
        public ActionResult SaveData(wms_user_department theData)
        {
            if(theData.Id == 0)
            {
                _wms_user_departmentBusiness.AddData(theData);
            }
            else
            {
                _wms_user_departmentBusiness.UpdateData(theData);
            }

            return Success();
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="theData">删除的数据</param>
        public ActionResult DeleteData(string ids)
        {
            _wms_user_departmentBusiness.DeleteData(ids.ToList<int>());

            return Success("删除成功！");
        }

        #endregion
    }
}