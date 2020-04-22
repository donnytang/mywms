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

        #region ��ͼ����

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

        #region ��ȡ����

        /// <summary>
        /// ��ȡ�����б�
        /// </summary>
        /// <param name="condition">��ѯ����</param>
        /// <param name="keyword">�ؼ���</param>
        /// <returns></returns>
        public ActionResult GetDataList(string condition, string keyword, Pagination pagination)
        {
            var dataList = _wms_user_departmentBusiness.GetDataList(condition, keyword, pagination);

            return Content(pagination.BuildTableResult_DataGrid(dataList).ToJson());
        }

        #endregion

        #region �ύ����

        /// <summary>
        /// ����
        /// </summary>
        /// <param name="theData">���������</param>
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
        /// ɾ������
        /// </summary>
        /// <param name="theData">ɾ��������</param>
        public ActionResult DeleteData(string ids)
        {
            _wms_user_departmentBusiness.DeleteData(ids.ToList<int>());

            return Success("ɾ���ɹ���");
        }

        #endregion
    }
}