using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OracleClient;
using System.Windows.Forms;
namespace ҽѧͼ����ϵͳ
{
    public class PatientInfo
    {
        private string strNum;//���

        public string StrNum
        {
            get { return strNum; }
            set { strNum = value; }
        }
        private string strName;//����

        public string StrName
        {
            get { return strName; }
            set { strName = value; }
        }
        private string strSex;//�Ա�

        public string StrSex
        {
            get { return strSex; }
            set { strSex = value; }
        }
        private string strWorkUnit;//������λ

        public string StrWorkUnit
        {
            get { return strWorkUnit; }
            set { strWorkUnit = value; }
        }
        private int iAge;

        public int IAge//����
        {
            get { return iAge; }
            set { iAge = value; }
        }
    }
    public class DoctorInfo
    {
        private string strNum;//���

        public string StrNum
        {
            get { return strNum; }
            set { strNum = value; }
        }
        private int iAge;

        public int IAge
        {
            get { return iAge; }
            set { iAge = value; }
        }
        private string strSex;

        public string StrSex
        {
            get { return strSex; }
            set { strSex = value; }
        }
        private string strName;//����
        public string StrName
        {
            get { return strName; }
            set { strName = value; }
        }
        private string strPassword;//����

        public string StrPassword
        {
            get { return strPassword; }
            set { strPassword = value; }
        }
        private string strAcademicTitle;

        public string StrAcademicTitle
        {
            get { return strAcademicTitle; }
            set { strAcademicTitle = value; }
        }
    }
}
