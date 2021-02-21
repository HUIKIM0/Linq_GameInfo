using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq_GameInfo
{
    public partial class Form1 : Form
    {
        const string sLEVEL = "레벨";
        const string sNAME = "이름";
        const string sATTRIBUTE = "속성";

        DataTable dt;

        enum EnumName
        {
            슬라임,
            가고일,
            드래곤,
            사신기사,
            고블린,
            언데드,
            서큐버스,
            골렘,
            웜,
            바실리스크,
        }

        enum EnumAttribute
        {
            불,
            물,
            바람,
            번개,
            어둠,
            빛,
            땅,
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTableCreate();
            DataEnemyCreate();
            ComboAttributeCreate();
        }

        /* ★ 테이블 틀(레벨/이름/속성) 생성하기 ★ */
        private void DataTableCreate()
        {
            dt = new DataTable("Enemy Info");

            // 데이터 테이블 칼럼 생성
            DataColumn colLevel = new DataColumn(sLEVEL, typeof(int));
            DataColumn colName = new DataColumn(sNAME, typeof(string));
            DataColumn colAttribute = new DataColumn(sATTRIBUTE, typeof(string));


            dt.Columns.Add(colLevel);
            dt.Columns.Add(colName);
            dt.Columns.Add(colAttribute);

        }


        /* 테이블에 데이터 값 넣기 */
        private void DataEnemyCreate()
        {
            Random rd = new Random();

            foreach (EnumName eName in Enum.GetValues(typeof(EnumName)))
            {
                DataRow dr = dt.NewRow();    //데이터 테이블에 새로운 Row 생성

                dr[sLEVEL] = rd.Next(1, 11);  // 레벨에 들어가는 값은 1~ 10 중에서 랜덤
                dr[sNAME] = eName.ToString();  // foreach문 돌려서 나오는 이름

                int iEnumAttribute = Enum.GetValues(typeof(EnumAttribute)).Length;  //enum EnumAttribute 길이(개수) 뽑아옴
                int iAttributeRandom = rd.Next(iEnumAttribute);  // enum 범위 내에서 랜덤
                dr[sATTRIBUTE] = ((EnumAttribute)iAttributeRandom);   // 나온 랜덤숫자 다시 enum으로 반환


                dt.Rows.Add(dr);
            }

            // ★DataGridView에 Data값들 넣어서 보여주기★
            dgGameInfo.DataSource = dt;
        }


        /* 레벨/이름/속성 별로 정렬하기 */
        private void btnSort_Click(object sender, EventArgs e)
        {
            Button Btn = sender as Button;

            DataTable dtCopy = dgGameInfo.DataSource as DataTable;  // 데이터그리드뷰에 있는 데이터를 dtCopy에 복사
            IEnumerable<DataRow> drSortTable = null;

            switch (Btn.Name)
            {
                case"btnLevel":
                    drSortTable = from oRow in dtCopy.AsEnumerable()
                                  orderby oRow.Field<int>(sLEVEL)
                                  select oRow;
                    break;

                case "btnName":
                    drSortTable = from oRow in dtCopy.AsEnumerable()
                                  orderby oRow.Field<string>(sNAME)
                                  select oRow;
                    break;

                case"btnAttribute":
                    drSortTable = from oRow in dtCopy.AsEnumerable()
                                  orderby oRow.Field<string>(sATTRIBUTE)
                                  select oRow;
                    break;

                default:
                    MessageBox.Show("정렬 과정에서 오류가 생겼습니다 :(");
                    break;
            }
            dtCopy = drSortTable.CopyToDataTable();
            dgGameInfo.DataSource = dtCopy;  
        }




        /* 콤보박스 enum EnumAttribute를 입력  */
        private void ComboAttributeCreate()
        {
            foreach (EnumAttribute eAttribute in Enum.GetValues(typeof(EnumAttribute)))
            {
                cboxAttribute.Items.Add(eAttribute);
            }
            cboxAttribute.SelectedIndex = 0;  //불
        }



        /* 필터 기능 -> 콤보박스(속성) && num업다운Min && num업다운Max */
        private void btnFilter_Click(object sender, EventArgs e)
        {
            DataTable dtCopy = dgGameInfo.DataSource as DataTable;
            IEnumerable<DataRow> drFilterData = from oRow in dtCopy.AsEnumerable()
                                                where oRow.Field<string>(sATTRIBUTE) == cboxAttribute.Text &&
                                                (oRow.Field<int>(sLEVEL) >= numLevelMin.Value && oRow.Field<int>(sLEVEL) <= numLevelMax.Value)
                                                select oRow;



            if (drFilterData.Count() > 0)
            {
                dtCopy = drFilterData.CopyToDataTable();
                dgGameInfo.DataSource = dtCopy;

            }
            else
            {
                MessageBox.Show("검색 조건에 맞는 데이터가 없습니다 :(");
            }

        }


        /* 초기화 하고 처음화면 보여주기 */
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // 데이터그리드뷰에 그 어떠한 작업도 안된 DataTable 던져줌
            dgGameInfo.DataSource = dt;
        }

    }
}
