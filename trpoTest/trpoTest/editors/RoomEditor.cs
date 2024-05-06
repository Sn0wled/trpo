using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trpoTest.selectors;

namespace trpoTest.editors
{
    public partial class RoomEditor : UserControl
    {
        // формы для выбора
        EmployeeSelector employeeSelector = new();
        public RoomEditor()
        {
            InitializeComponent();
            employeeSelector.Selected += HandleEmployeeSelected;
        }
        // начальные значения
        int startZbmId;
        string startBuildingNumber;
        string startRoomNumber;
        // значения
        public int CurZbmId { get; private set; }
        public string CurZbmName {  get; private set; }
        public string CurBuildingNumber { get; private set; }
        public string CurRoomNumber { get; private set; }
        public string CurRespEmpTabNum { get; private set; }

        // показатель редактирования

        bool isEditor;

        // иницаиализация Редактора
        public void Init(int zbmId, string zbmName, string buildingNumber, string? roomNumber, string? respEmpTabNum)
        {
            InitStart(zbmId, zbmName, buildingNumber, roomNumber, respEmpTabNum);
            InitFormVals();
        }

        // инициализация начальных значений
        void InitStart(int zbmId, string zbmName, string buildingNumber, string? roomNumber, string? respEmpTabNum)
        {
            startZbmId = zbmId;
            startBuildingNumber = buildingNumber;
            CurZbmName = zbmName;
            if (roomNumber != null && respEmpTabNum != null)
            {
                isEditor = true;
                editorLabel.Text = "Редактирование помещения";
                startRoomNumber = roomNumber;
                CurRespEmpTabNum = respEmpTabNum;
            }
            else
            {
                isEditor = false;
                editorLabel.Text = "Добавление помещения";
                startRoomNumber = "";
                CurRespEmpTabNum = "";
            }
        }

        // инициализация значений в форме
        public void InitFormVals()
        {
            roomNum.Text = startRoomNumber;
            zbmNameText.Text = CurZbmName;
            buildingNumberText.Text = startBuildingNumber;
            respEmpTabNumText.Text = CurRespEmpTabNum;
        }

        // при выборе в селекторах
        public void HandleEmployeeSelected(object? o, EventArgs e)
        {
            CurRespEmpTabNum = employeeSelector.SelectedTabNum;
            respEmpTabNumText.Text = employeeSelector.SelectedTabNum;
        }

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            employeeSelector.Init();
            employeeSelector.Select(CurRespEmpTabNum);
        }
    }

}
