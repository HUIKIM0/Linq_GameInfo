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
            DataEnemy();
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
        private void DataEnemy()
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

            // DataGridView에 DataTable값들 넣어서 보여주기
            dgGameInfo.DataSource = dt;
        }

    }

    /* 레벨/이름/속성 별로 정렬하기 */

    /* 콤보박스 속성별로 정보보기  */

    /* 필터 기능 */

    /* 초기화 하고 처음화면 보여주기 */

}
