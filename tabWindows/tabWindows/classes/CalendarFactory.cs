using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UImockUp
{
    class CalendarFactory
    {
        int _Month;
        int _Day;
        int _Week;

        public int Week
        {
            get { return _Week; }
            set { _Week = value; }
        }

        public int Day
        {
            get { return _Day; }
            set { _Day = value; }
        }

        public int Dato
        {
            get { return _Month; }
            set { _Month = value; }
        }



        public Grid calendarBuild(int Day, int Month, int Year)
        {
            
            Grid XXcalendar = new Grid();
    
            DateTime CurrTime = DateTime.Now;
            String CurrDay = CurrTime.Day.ToString("d");

            int day = Day;
            int month = Month;
            int year = Year;

            int DaysInMonth = DateTime.DaysInMonth(year, month);
            
            //lblDate.Content = CurrTime.ToString("dddddd d MMMMMMMM yyyy");
            //lblDate.Content = CurrTime.ToString("dddddddd");

            XXcalendar.Width = 611;
            XXcalendar.Height = 477;
            XXcalendar.HorizontalAlignment = HorizontalAlignment.Center;
            XXcalendar.VerticalAlignment = VerticalAlignment.Center;
            XXcalendar.ShowGridLines = true;


            // Define the Columns
            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            ColumnDefinition colDef5 = new ColumnDefinition();
            ColumnDefinition colDef6 = new ColumnDefinition();
            ColumnDefinition colDef7 = new ColumnDefinition();

            XXcalendar.ColumnDefinitions.Add(colDef1);
            XXcalendar.ColumnDefinitions.Add(colDef2);
            XXcalendar.ColumnDefinitions.Add(colDef3);
            XXcalendar.ColumnDefinitions.Add(colDef4);
            XXcalendar.ColumnDefinitions.Add(colDef5);
            XXcalendar.ColumnDefinitions.Add(colDef6);
            XXcalendar.ColumnDefinitions.Add(colDef7);

            // Define the Rows
            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            RowDefinition rowDef5 = new RowDefinition();
            XXcalendar.RowDefinitions.Add(rowDef1);
            XXcalendar.RowDefinitions.Add(rowDef2);
            XXcalendar.RowDefinitions.Add(rowDef3);
            XXcalendar.RowDefinitions.Add(rowDef4);
            XXcalendar.RowDefinitions.Add(rowDef5);

            int row = 0;
            int col = 0;

            Brush brushRed = new SolidColorBrush(Colors.Red);
            Brush brushGreen = new SolidColorBrush(Colors.Green);
            Brush brushBlue = new SolidColorBrush(Colors.LightSteelBlue);
            Brush brushOtherRed = new SolidColorBrush(Colors.Maroon);

            for (int i = 1; i <= DaysInMonth; i++)
            {
                TextBlock txt = new TextBlock();
                DateTime CurrentDay = new DateTime(year, month, i);
               
                txt.Text = "Dag: " + i + " ";
                txt.Text += CurrentDay.ToString("ddddd");
                txt.FontSize = 10;

                txt.Background = brushBlue;

                Grid.SetColumn(txt, col);
                Grid.SetRow(txt, row);

                col++;

                switch (CurrentDay.ToString("dddddd"))
                {
                    case "lørdag":
                        txt.Background = brushOtherRed;
                        break;
                    case "søndag":
                        txt.Background = brushRed;
                        break;                      
                    default:
                        txt.Background = brushBlue;
                        break;
                }

                switch (i)
                {
                    case 0:
                        row = 0;
                        col = 0;
                        break;
                    case 7:
                        Grid.SetRow(txt, 0);                        
                        row = 1;
                        col = 0;
                        break;

                    case 14:
                        Grid.SetRow(txt, 1);
                        row = 2;
                        col = 0;
                        break;
                    case 21:
                        Grid.SetRow(txt, 2);
                        row = 3;
                        col = 0;
                        break;
                    case 28:
                        Grid.SetRow(txt, 3);
                        row = 4;
                        col = 0;
                        break;                                                                                     
                }

                if (day == i)
                {
                    txt.Background = brushGreen;
                }
                
                XXcalendar.Children.Add(txt);
            }
            return XXcalendar;
            //CalendarPanel.Children.Add(XXcalendar);
            
        }
    }
}
