using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace NEURON.WINDOW.UI
{
    public class DataGridViewCalendarColumn : DataGridViewColumn
    {
        private bool showUpDown = true;
        public bool ShowUpDown
        {
            get
            {
                return showUpDown;
            }
            set
            {
                showUpDown = value;
            }
        }
        public DataGridViewCalendarColumn()
            : base(new DataGridViewCalendarCell())
        {
        }
        public override DataGridViewCell CellTemplate
        {
            get
            {
                return base.CellTemplate;
            }
            set
            {
                if (value != null &&
                !value.GetType().IsAssignableFrom(typeof(DataGridViewCalendarCell)))
                {
                    throw new InvalidCastException("Must be a CalendarCell");
                }
                base.CellTemplate = value;
            }
        }
        private void InitializeComponent()
        {
        }
    }

    public class DataGridViewCalendarCell : DataGridViewTextBoxCell
    {
        public DataGridViewCalendarCell()
            : base()
        {
        }
        public override void InitializeEditingControl(int rowIndex, object
        initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
            DataGridViewCalendarEditingControl ctl =
            DataGridView.EditingControl as DataGridViewCalendarEditingControl;
            ctl.Text = this.Value.ToString();
        }
        public override Type EditType
        {
            get
            {
                return typeof(DataGridViewCalendarEditingControl);
            }
        }
        public override Type ValueType
        {
            get
            {
                return typeof(DateTime);
            }
        }
        public override object DefaultNewRowValue
        {
            get
            {
                return DateTime.Now;
            }
        }
    }

    public class DataGridViewCalendarEditingControl : DateTimePicker, IDataGridViewEditingControl
    {
        DataGridView dataGridView;
        private bool valueChanged = false;
        int rowIndex;
        public DataGridViewCalendarEditingControl()
        {
        }
        public object EditingControlFormattedValue
        {
            get
            {
                return this.Value.ToLongDateString();
            }
            set
            {
                String newValue = value as String;
                if (newValue != null)
                {
                    this.Value = DateTime.Parse(newValue);
                }
            }
        }
        public object GetEditingControlFormattedValue(
        DataGridViewDataErrorContexts context)
        {
            return EditingControlFormattedValue;
        }
        public void ApplyCellStyleToEditingControl(
        DataGridViewCellStyle dataGridViewCellStyle)
        {
            this.Font = dataGridViewCellStyle.Font;
            this.CalendarForeColor = dataGridViewCellStyle.ForeColor;
            this.CalendarMonthBackground = dataGridViewCellStyle.BackColor;
        }
        public int EditingControlRowIndex
        {
            get
            {
                return rowIndex;
            }
            set
            {
                rowIndex = value;
            }
        }
        public bool EditingControlWantsInputKey(
        Keys key, bool dataGridViewWantsInputKey)
        {
            switch (key & Keys.KeyCode)
            {
                case Keys.Left:
                case Keys.Up:
                case Keys.Down:
                case Keys.Right:
                case Keys.Home:
                case Keys.End:
                case Keys.PageDown:
                case Keys.PageUp:
                    return true;
                default:
                    return false;
            }
        }
        public void PrepareEditingControlForEdit(bool selectAll)
        {
        }
        public bool RepositionEditingControlOnValueChange
        {
            get
            {
                return false;
            }
        }
        public DataGridView EditingControlDataGridView
        {
            get
            {
                return dataGridView;
            }
            set
            {
                dataGridView = value;
            }
        }
        public bool EditingControlValueChanged
        {
            get
            {
                return valueChanged;
            }
            set
            {
                valueChanged = value;
            }
        }
        public Cursor EditingPanelCursor
        {
            get
            {
                return base.Cursor;
            }
        }
        protected override void OnValueChanged(EventArgs eventargs)
        {
            valueChanged = true;
            this.EditingControlDataGridView.NotifyCurrentCellDirty(true);
            base.OnValueChanged(eventargs);
        }
    }

}
