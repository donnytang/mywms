using Coldairarrow.Business.warehouse;
using Coldairarrow.Entity.warehouse;
using Coldairarrow.Util;
using System;
using System.Web.Mvc;

namespace Coldairarrow.Web
{
    public class wms_userController : BaseMvcController
    {
        wms_userBusiness _wms_userBusiness = new wms_userBusiness();

        #region ��ͼ����

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form(int id = 0)
        {
            var theData = id == 0 ? new wms_user() : _wms_userBusiness.GetTheData(id);

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
            var dataList = _wms_userBusiness.GetDataList(condition, keyword, pagination);

            return Content(pagination.BuildTableResult_DataGrid(dataList).ToJson());
        }

        #endregion

        #region �ύ����

        /// <summary>
        /// ����
        /// </summary>
        /// <param name="theData">���������</param>
        public ActionResult SaveData(wms_user theData)
        {
            if(theData.Id == 0)
            {
                _wms_userBusiness.AddData(theData);
            }
            else
            {
                _wms_userBusiness.UpdateData(theData);
            }

            return Success();
        }

        /// <summary>
        /// ɾ������
        /// </summary>
        /// <param name="theData">ɾ��������</param>
        public ActionResult DeleteData(string ids)
        {
            _wms_userBusiness.DeleteData(ids.ToList<int>());

            return Success("ɾ���ɹ���");
        }

        #endregion
    }
}