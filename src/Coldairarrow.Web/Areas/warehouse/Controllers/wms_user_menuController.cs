using Coldairarrow.Business.warehouse;
using Coldairarrow.Entity.warehouse;
using Coldairarrow.Util;
using System;
using System.Web.Mvc;

namespace Coldairarrow.Web
{
    public class wms_user_menuController : BaseMvcController
    {
        wms_user_menuBusiness _wms_user_menuBusiness = new wms_user_menuBusiness();

        #region ��ͼ����

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form(int id = 0)
        {
            var theData = id == 0 ? new wms_user_menu() : _wms_user_menuBusiness.GetTheData(id);

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
            var dataList = _wms_user_menuBusiness.GetDataList(condition, keyword, pagination);

            return Content(pagination.BuildTableResult_DataGrid(dataList).ToJson());
        }

        #endregion

        #region �ύ����

        /// <summary>
        /// ����
        /// </summary>
        /// <param name="theData">���������</param>
        public ActionResult SaveData(wms_user_menu theData)
        {
            if(theData.Id == 0)
            {
                _wms_user_menuBusiness.AddData(theData);
            }
            else
            {
                _wms_user_menuBusiness.UpdateData(theData);
            }

            return Success();
        }

        /// <summary>
        /// ɾ������
        /// </summary>
        /// <param name="theData">ɾ��������</param>
        public ActionResult DeleteData(string ids)
        {
            _wms_user_menuBusiness.DeleteData(ids.ToList<int>());

            return Success("ɾ���ɹ���");
        }

        #endregion
    }
}