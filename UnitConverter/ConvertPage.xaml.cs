﻿using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Microsoft.Phone.Controls;

namespace UnitConverter
{

    public partial class ConvertPage : PhoneApplicationPage
    {

        public ConvertPage()
        {
         
            InitializeComponent();
        }

        private string category = "";
        private string tempQuantity = "";

        private double LeftUnitQuantity = 0;
        private double RightUnitQuantity = 0;

        private int LeftSelectedIndex = 0;
        private int RightSelectedIndex = 0;

        private bool isInitial = true;

        private bool isLeftConvert = false;
        private bool isRightConvert = false;

        private Unit LeftUnit = new Unit();
        private Unit RightUnit = new Unit();

        private UnitList currentList = new UnitList();


        public void LangChange(string categoryParam, int type = 3)
        {
            switch (type)
            {
                case 1:
                    TipTextBlock.Text = "Sélectionnez une unité!";
                    switch (categoryParam)
                    {
                        case "weight":
                            PageTitle.Text = String.Format("{0}", "Poids");
                            break;                        
                        case "length":
                            PageTitle.Text = String.Format("{0}", "Distance");
                            break;
                        case  "energy":
                            PageTitle.Text = String.Format("{0}", "énergie");
                            break;
                        case  "volume":
                            PageTitle.Text = String.Format("{0}", "Tome");
                            break;
                        case "area":
                            PageTitle.Text = String.Format("{0}", "Zone");
                            break;
                        case "angle":
                            PageTitle.Text = String.Format("{0}", "Angle");
                            break;
                    }
                    break;
                case 2:
                    TipTextBlock.Text = "Selezionare un'Unità!";
                    switch (categoryParam)
                    {
                        case "weight":
                            PageTitle.Text = String.Format("{0}", "Di Peso");
                            break;                        
                        case "length":
                            PageTitle.Text = String.Format("{0}", "Distanza");
                            break;
                        case  "energy":
                            PageTitle.Text = String.Format("{0}", "Energia");
                            break;
                        case  "volume":
                            PageTitle.Text = String.Format("{0}", "Capacità");
                            break;
                        case "area":
                            PageTitle.Text = String.Format("{0}", "Zona");
                            break;
                        case "angle":
                            PageTitle.Text = String.Format("{0}", "Angolo");
                            break;
                    }                    break;
                case 3:
                    TipTextBlock.Text = "Select an Unit!";
                    switch (categoryParam)
                    {
                        case "weight":
                            PageTitle.Text = String.Format("{0}", "Weight");
                            break;                        
                        case "length":
                            PageTitle.Text = String.Format("{0}", "Length");
                            break;
                        case  "energy":
                            PageTitle.Text = String.Format("{0}", "Energy");
                            break;
                        case  "volume":
                            PageTitle.Text = String.Format("{0}", "Volume");
                            break;
                        case "area":
                            PageTitle.Text = String.Format("{0}", "Area");
                            break;
                        case "angle":
                            PageTitle.Text = String.Format("{0}", "Angle");
                            break;
                    }                     break;
                case 4:
                    TipTextBlock.Text = "Selecione uma Unidade!";
                    switch (categoryParam)
                    {
                        case "weight":
                            PageTitle.Text = String.Format("{0}", "Peso");
                            break;                        
                        case "length":
                            PageTitle.Text = String.Format("{0}", "Comprimento");
                            break;
                        case  "energy":
                            PageTitle.Text = String.Format("{0}", "Energia");
                            break;
                        case  "volume":
                            PageTitle.Text = String.Format("{0}", "Capacità");
                            break;
                        case "area":
                            PageTitle.Text = String.Format("{0}", "Zona");
                            break;
                        case "angle":
                            PageTitle.Text = String.Format("{0}", "ângulo");
                            break;
                    }                     break;
            }
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            category = NavigationContext.QueryString["Category"];
            LangChange(category, MyGlobals.Total);
            switch (category)
            {
                case "weight":
                    {
                        LeftUnitPicker.ItemsSource = Category.WeightUnits.UnitItems;
                        RightUnitPicker.ItemsSource = Category.WeightUnits.UnitItems;
                        currentList = Category.WeightUnits;
                        break; 
                    }
                case "length":
                    {
                        LeftUnitPicker.ItemsSource = Category.LengthUnits.UnitItems;
                        RightUnitPicker.ItemsSource = Category.LengthUnits.UnitItems;
                        currentList = Category.LengthUnits;
                        break;
                    }
                case "area":
                    {
                        LeftUnitPicker.ItemsSource = Category.AreaUnits.UnitItems;
                        RightUnitPicker.ItemsSource = Category.AreaUnits.UnitItems;
                        currentList = Category.AreaUnits;
                        break;
                    }
                case "volume":
                    {
                        LeftUnitPicker.ItemsSource = Category.VolumeUnits.UnitItems;
                        RightUnitPicker.ItemsSource = Category.VolumeUnits.UnitItems;
                        currentList = Category.VolumeUnits;
                        break;
                    }
                case "energy":
                    {
                        LeftUnitPicker.ItemsSource = Category.EnergyUnits.UnitItems;
                        RightUnitPicker.ItemsSource = Category.EnergyUnits.UnitItems;
                        currentList = Category.EnergyUnits;
                        break;
                    }
                case "angle":
                    {
                        LeftUnitPicker.ItemsSource = Category.AngleUnits.UnitItems;
                        RightUnitPicker.ItemsSource = Category.AngleUnits.UnitItems;
                        currentList = Category.AngleUnits;
                        break;
                    }
                case "power":
                    {
                        LeftUnitPicker.ItemsSource = Category.PowerUnits.UnitItems;
                        RightUnitPicker.ItemsSource = Category.PowerUnits.UnitItems;
                        currentList = Category.PowerUnits;
                        break;
                    }
                case "pressure":
                    {
                        LeftUnitPicker.ItemsSource = Category.PressureUnits.UnitItems;
                        RightUnitPicker.ItemsSource = Category.PressureUnits.UnitItems;
                        currentList = Category.PressureUnits;
                        break;
                    }
                case "temperature":
                    {
                        LeftUnitPicker.ItemsSource = Category.TemperatureUnits.UnitItems;
                        RightUnitPicker.ItemsSource = Category.TemperatureUnits.UnitItems;
                        MinusTipTextBlock.Visibility = Visibility.Visible;
                        LeftMinusTextBlock.Visibility = Visibility.Visible;
                        RightMinusTextBlock.Visibility = Visibility.Visible;
                        LeftUnitTextBox.Width = 390;
                        RightUnitTextBox.Width = 390;
                        LeftUnitTextBox.Margin = new Thickness(54, 101, 0, 0);
                        RightUnitTextBox.Margin = new Thickness(54, 368, 0, 0);
                        TipTextBlock.Margin = new Thickness(0, 15, 0, 0);
                        currentList = Category.TemperatureUnits;
                        break;
                    }
                case "velocity":
                    {
                        LeftUnitPicker.ItemsSource = Category.VelocityUnits.UnitItems;
                        RightUnitPicker.ItemsSource = Category.VelocityUnits.UnitItems;
                        currentList = Category.VelocityUnits;
                        break;
                    }
               
            }
            if (isInitial)
            {
                switch (category)
                {
                    case "weight":
                        {
                            LeftUnitPicker.SelectedIndex = 5;
                            break;
                        }
                    case "length":
                        {
                            LeftUnitPicker.SelectedIndex = 10;
                            break;
                        }
                    case "area":
                        {
                            LeftUnitPicker.SelectedIndex = 4;
                            break;
                        }
                    case "volume":
                        {
                            LeftUnitPicker.SelectedIndex = 7;
                            break;
                        }
                    case "energy":
                        {
                            LeftUnitPicker.SelectedIndex = 1;
                            break;
                        }
                    case "angle":
                        {
                            LeftUnitPicker.SelectedIndex = 1;
                            break;
                        }
                    case "power":
                        {
                            LeftUnitPicker.SelectedIndex = 3;
                            break;
                        }
                    case "pressure":
                        {
                            LeftUnitPicker.SelectedIndex = 7;
                            break;
                        }
                    case "temperature":
                        {
                            LeftUnitPicker.SelectedIndex = 1;
                            break;
                        }
                    case "velocity":
                        {
                            LeftUnitPicker.SelectedIndex = 1;
                            break;
                        }
                    case "货币":
                        {
                            LeftUnitPicker.SelectedIndex = 3;
                            break;
                        }
                }
            }
            isInitial = false;
        }

        private void LeftUnitPicker_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LeftUnit = (sender as ListPicker).SelectedItem as Unit;
            LeftSelectedIndex = (sender as ListPicker).SelectedIndex;
            if (!isInitial)
            {
                isRightConvert = true;
                if (Warning())
                {
                    Convert();
                    ShowLeftUnit();
                }
            }
        }

        private void RightUnitPicker_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RightUnit = (sender as ListPicker).SelectedItem as Unit;
            RightSelectedIndex = (sender as ListPicker).SelectedIndex;
            if (!isInitial)
            {
                isLeftConvert = true;
                if (Warning())
                {
                    Convert();
                    ShowRightUnit();
                }
            }
        }

        #region LeftUnitTextBox
        private void LeftUnitTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isLeftConvert && LeftUnitTextBox.Text != "")
            {
                if (double.TryParse(LeftUnitTextBox.Text, out LeftUnitQuantity))
                {
                    if (Warning())
                    {
                        Convert();
                        ShowRightUnit();
                        tempQuantity = LeftUnitTextBox.Text;
                    }
                }
                else
                {
                    MessageBox.Show("输入有误，请重新输入！");
                    LeftUnitTextBox.Text = tempQuantity;
                    LeftUnitTextBox.Select(LeftUnitTextBox.Text.Length, 0);
                    LeftUnitQuantity = double.Parse(LeftUnitTextBox.Text);
                    if (Warning())
                    {
                        Convert();
                        ShowRightUnit();
                    }
                }
            }
        }

        private void LeftUnitTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            isLeftConvert = true;
        }

        private void LeftUnitTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            LeftUnitTextBox.Text = "";
        }

        private void LeftUnitTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (LeftUnitTextBox.Text == "")
                LeftUnitTextBox.Text = "0";
            isLeftConvert = true;
            if (double.TryParse(LeftUnitTextBox.Text, out LeftUnitQuantity) && Warning())
            {
                Convert();
                ShowRightUnit();
            }            
        }
        #endregion

        #region RightUnitTextBox
        private void RightUnitTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isRightConvert && RightUnitTextBox.Text != "")
            {
                if (double.TryParse(RightUnitTextBox.Text, out RightUnitQuantity))
                {
                    if (Warning())
                    {
                        Convert();
                        ShowLeftUnit();
                        tempQuantity = RightUnitTextBox.Text;
                    }
                }
                else
                {
                    MessageBox.Show("输入有误，请重新输入！");
                    RightUnitTextBox.Text = tempQuantity;
                    RightUnitTextBox.Select(RightUnitTextBox.Text.Length, 0);
                    RightUnitQuantity = double.Parse(RightUnitTextBox.Text);
                    if (Warning())
                    {
                        Convert();
                        ShowLeftUnit();
                    }
                }
            }
        }

        private void RightUnitTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            isRightConvert = true;
        }

        private void RightUnitTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            RightUnitTextBox.Text = "";
        }

        private void RightUnitTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (RightUnitTextBox.Text == "")
                RightUnitTextBox.Text = "0";
            isRightConvert = true;
            if (double.TryParse(RightUnitTextBox.Text, out RightUnitQuantity) && Warning())
            {
                Convert();
                ShowLeftUnit();
            }
        }
        #endregion

        private void LeftMinusTextBlock_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (category == "temperature")
            {
                if (LeftUnitQuantity <= 0)
                {
                    LeftMinusTextBlock.Foreground = new SolidColorBrush(Color.FromArgb(50, 255, 255, 255));
                    LeftUnitQuantity = Math.Abs(LeftUnitQuantity);
                }
                else
                {
                    LeftMinusTextBlock.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                    LeftUnitQuantity = 0 - Math.Abs(LeftUnitQuantity);
                }
                isLeftConvert = true;
                if (Warning())
                {
                    Convert();
                    ShowRightUnit();
                } 
            }
        }

        private void RightMinusTextBlock_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if(category=="temperature")
            {
                if (RightUnitQuantity <= 0)
                {
                    RightMinusTextBlock.Foreground = new SolidColorBrush(Color.FromArgb(50, 255, 255, 255));
                    RightUnitQuantity = Math.Abs(RightUnitQuantity);
                }
                else
                {
                    RightMinusTextBlock.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                    RightUnitQuantity = 0 - Math.Abs(RightUnitQuantity);
                }
                isRightConvert = true;
                if(Warning())
                {
                    Convert();
                    ShowLeftUnit();
                }
            }
        }

        private void ExchangeButton_Click(object sender, RoutedEventArgs e)
        {
            isLeftConvert = true;
            LeftUnitTextBox.Text = RightUnitTextBox.Text;
            LeftUnitQuantity = double.Parse(LeftUnitTextBox.Text);
            int tempIndex = LeftSelectedIndex;
            LeftUnitPicker.SelectedIndex = RightSelectedIndex;
            RightUnitPicker.SelectedIndex = tempIndex;
        }



        private void Convert()
        {
            try
            {
                if (LeftUnit == RightUnit)
                {
                    if (isLeftConvert)
                        RightUnitQuantity = LeftUnitQuantity;
                    else
                        LeftUnitQuantity = RightUnitQuantity;
                }
                else
                {
                    double temp = 0;
                    if (category == "temperature")
                    {
                        #region temperature
                        if (isLeftConvert)
                        {
                            switch (LeftUnit.Name_Symbol)
                            {
                                case "摄氏度(℃)":
                                    {
                                        temp = LeftUnitQuantity;
                                        break;
                                    }
                                case "华氏度(℉)":
                                    {
                                        temp = (LeftUnitQuantity - 32) / 1.8;
                                        break;
                                    }
                                case "兰氏度(°R)":
                                    {
                                        temp = LeftUnitQuantity / 1.8 - 273.15;
                                        break;
                                    }
                                case "列氏度(°Re)":
                                    {
                                        temp = LeftUnitQuantity * 1.25;
                                        break;
                                    }
                                case "开氏度(K)":
                                    {
                                        temp = LeftUnitQuantity - 273.15;
                                        break;
                                    }
                            }
                            switch (RightUnit.Name_Symbol)
                            {
                                case "摄氏度(℃)":
                                    {
                                        RightUnitQuantity = temp;
                                        break;
                                    }
                                case "华氏度(℉)":
                                    {
                                        RightUnitQuantity = temp * 1.8 + 32;
                                        break;
                                    }
                                case "兰氏度(°R)":
                                    {
                                        RightUnitQuantity = (temp + 273.15) * 1.8;
                                        break;
                                    }
                                case "列氏度(°Re)":
                                    {
                                        RightUnitQuantity = temp / 1.25;
                                        break;
                                    }
                                case "开氏度(K)":
                                    {
                                        RightUnitQuantity = temp + 273.15;
                                        break;
                                    }
                            }
                        }
                        else
                        {
                            switch (RightUnit.Name_Symbol)
                            {
                                case "摄氏度(℃)":
                                    {
                                        temp = RightUnitQuantity;
                                        break;
                                    }
                                case "华氏度(℉)":
                                    {
                                        temp = (RightUnitQuantity - 32) / 1.8;
                                        break;
                                    }
                                case "兰氏度(°R)":
                                    {
                                        temp = RightUnitQuantity / 1.8 - 273.15;
                                        break;
                                    }
                                case "列氏度(°Re)":
                                    {
                                        temp = RightUnitQuantity * 1.25;
                                        break;
                                    }
                                case "开氏度(K)":
                                    {
                                        temp = RightUnitQuantity - 273.15;
                                        break;
                                    }
                            }
                            switch (LeftUnit.Name_Symbol)
                            {
                                case "摄氏度(℃)":
                                    {
                                        LeftUnitQuantity = temp;
                                        break;
                                    }
                                case "华氏度(℉)":
                                    {
                                        LeftUnitQuantity = temp * 1.8 + 32;
                                        break;
                                    }
                                case "兰氏度(°R)":
                                    {
                                        LeftUnitQuantity = (temp + 273.15) * 1.8;
                                        break;
                                    }
                                case "列氏度(°Re)":
                                    {
                                        LeftUnitQuantity = temp / 1.25;
                                        break;
                                    }
                                case "开氏度(K)":
                                    {
                                        LeftUnitQuantity = temp + 273.15;
                                        break;
                                    }
                            }
                        }
                        #endregion
                    }
                    else
                    {
                        if (isLeftConvert)
                        {
                            if (LeftUnit.Classfication == RightUnit.Classfication)
                            {
                                RightUnitQuantity = LeftUnitQuantity * LeftUnit.StandardCoeffient / LeftUnit.SelfCoeffient * RightUnit.SelfCoeffient / RightUnit.StandardCoeffient;
                            }
                            else
                            {
                                switch (LeftUnit.Classfication)
                                {
                                    case "Metric":
                                        {
                                            temp = LeftUnitQuantity * LeftUnit.StandardCoeffient / LeftUnit.SelfCoeffient;
                                            break;
                                        }
                                    case "British":
                                        {
                                            temp = LeftUnitQuantity * LeftUnit.StandardCoeffient / LeftUnit.SelfCoeffient * currentList.Metric_British;
                                            break;
                                        }
                                    case "Imperial":
                                        {
                                            temp = LeftUnitQuantity * LeftUnit.StandardCoeffient / LeftUnit.SelfCoeffient * currentList.Metric_Imperial;
                                            break;
                                        }
                                    case "American":
                                        {
                                            temp = LeftUnitQuantity * LeftUnit.StandardCoeffient / LeftUnit.SelfCoeffient * currentList.Metric_American;
                                            break;
                                        }
                                }
                                switch (RightUnit.Classfication)
                                {
                                    case "Metric":
                                        {
                                            RightUnitQuantity = temp * RightUnit.SelfCoeffient / RightUnit.StandardCoeffient;
                                            break;
                                        }
                                    case "British":
                                        {
                                            RightUnitQuantity = temp * RightUnit.SelfCoeffient / RightUnit.StandardCoeffient / currentList.Metric_British;
                                            break;
                                        }
                                    case "Imperial":
                                        {
                                            RightUnitQuantity = temp * RightUnit.SelfCoeffient / RightUnit.StandardCoeffient / currentList.Metric_Imperial;
                                            break;
                                        }
                                    case "American":
                                        {
                                            RightUnitQuantity = temp * RightUnit.SelfCoeffient / RightUnit.StandardCoeffient / currentList.Metric_American;
                                            break;
                                        }
                                }
                            }
                        }
                        else
                        {
                            if (RightUnit.Classfication == LeftUnit.Classfication)
                            {
                                LeftUnitQuantity = RightUnitQuantity * RightUnit.StandardCoeffient / RightUnit.SelfCoeffient * LeftUnit.SelfCoeffient / LeftUnit.StandardCoeffient;
                            }
                            else
                            {
                                switch (RightUnit.Classfication)
                                {
                                    case "Metric":
                                        {
                                            temp = RightUnitQuantity * RightUnit.StandardCoeffient / RightUnit.SelfCoeffient;
                                            break;
                                        }
                                    case "British":
                                        {
                                            temp = RightUnitQuantity * RightUnit.StandardCoeffient / RightUnit.SelfCoeffient * currentList.Metric_British;
                                            break;
                                        }
                                    case "Imperial":
                                        {
                                            temp = RightUnitQuantity * RightUnit.StandardCoeffient / RightUnit.SelfCoeffient * currentList.Metric_Imperial;
                                            break;
                                        }
                                    case "American":
                                        {
                                            temp = RightUnitQuantity * RightUnit.StandardCoeffient / RightUnit.SelfCoeffient * currentList.Metric_American;
                                            break;
                                        }
                                }
                                switch (LeftUnit.Classfication)
                                {
                                    case "Metric":
                                        {
                                            LeftUnitQuantity = temp * LeftUnit.SelfCoeffient / LeftUnit.StandardCoeffient;
                                            break;
                                        }
                                    case "British":
                                        {
                                            LeftUnitQuantity = temp * LeftUnit.SelfCoeffient / LeftUnit.StandardCoeffient / currentList.Metric_British;
                                            break;
                                        }
                                    case "Imperial":
                                        {
                                            LeftUnitQuantity = temp * LeftUnit.SelfCoeffient / LeftUnit.StandardCoeffient / currentList.Metric_Imperial;
                                            break;
                                        }
                                    case "American":
                                        {
                                            LeftUnitQuantity = temp * LeftUnit.SelfCoeffient / LeftUnit.StandardCoeffient / currentList.Metric_American;
                                            break;
                                        }
                                }
                            }
                        }
                    }
                }
            }
            catch
            { }
            isLeftConvert = false;
            isRightConvert = false;
        }

        private void ShowLeftUnit()
        {
            if (LeftUnitQuantity < 0)
                LeftMinusTextBlock.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            else
                LeftMinusTextBlock.Foreground = new SolidColorBrush(Color.FromArgb(50, 255, 255, 255));
            LeftUnitTextBox.Text = Math.Abs(LeftUnitQuantity).ToString();
        }

        private void ShowRightUnit()
        {
            if (RightUnitQuantity < 0)
                RightMinusTextBlock.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            else
                RightMinusTextBlock.Foreground = new SolidColorBrush(Color.FromArgb(50, 255, 255, 255));
            RightUnitTextBox.Text = Math.Abs(RightUnitQuantity).ToString();
        }

        private bool Warning()
        {
            if (category == "temperature" && isLeftConvert &&((LeftUnit.Name_Symbol == "摄氏度(℃)" && LeftUnitQuantity < -273.15) || 
                (LeftUnit.Name_Symbol == "华氏度(℉)" && LeftUnitQuantity < -459.67) || (LeftUnit.Name_Symbol == "兰氏度(°R)" && LeftUnitQuantity < 0) ||
                (LeftUnit.Name_Symbol == "列氏度(°Re)" && LeftUnitQuantity < -216.92) || (LeftUnit.Name_Symbol == "开氏度(K)" && LeftUnitQuantity < 0)))
            {
                MessageBox.Show("输入范围有误，请重新输入。");
                LeftUnitQuantity = double.Parse(tempQuantity);
                ShowLeftUnit();
                Convert();
                ShowRightUnit();
                return false;
            }
            else if(category == "temperature" && isRightConvert &&((RightUnit.Name_Symbol == "摄氏度(℃)" && RightUnitQuantity < -273.15) || 
                    (RightUnit.Name_Symbol == "华氏度(℉)" && RightUnitQuantity < -459.67) || (RightUnit.Name_Symbol == "兰氏度(°R)" && RightUnitQuantity < 0) || 
                    (RightUnit.Name_Symbol == "列氏度(°Re)" && RightUnitQuantity < -216.92) || (RightUnit.Name_Symbol == "开氏度(K)" && RightUnitQuantity < 0)))
            {
                MessageBox.Show("输入范围有误，请重新输入。");
                RightUnitQuantity = double.Parse(tempQuantity);
                ShowRightUnit();
                Convert();
                ShowLeftUnit();
                return false;
            }
            else
                return true;
        }

        

        
    }
}