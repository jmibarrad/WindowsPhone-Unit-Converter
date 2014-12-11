using System.Collections.Generic;

namespace UnitConverter
{
    public class Category:UnitList
    {

        private static List<Unit> weight2 = new List<Unit>();

        #region weightvars
        private static string w1;
        private static string w2;
        private static string w3;
        private static string w4;
        private static string w5;
        private static string w6;
        private static string w7;
        #endregion

        #region lengthvars
        private static string l1;
        private static string l2;
        private static string l3;
        private static string l4;
        private static string l5;
        private static string l6;
        private static string l7;
        private static string l8;
        private static string l9;
        private static string l10;
        private static string l11;
        #endregion

        #region areavars
        private static string a1;
        private static string a2;
        private static string a3;
        private static string a4;
        private static string a5;
        #endregion

        #region volumevars
        private static string v1;
        private static string v2;
        private static string v3;
        private static string v4;
        private static string v5;
        private static string v6;
        private static string v7;
        private static string v8;

        #endregion

        #region energyvars

        private static string e1;
        private static string e2;
        private static string e3;
        
        #endregion

        #region anglevars

        private static string d;
        private static string r;
        #endregion

        #region Weight
        private static List<Unit> weight = new List<Unit>
        {            
            new Unit { Name_Symbol = w1+"(g)", SelfCoeffient = 1, StandardCoeffient = 1, Classfication = "Metric" },
            new Unit { Name_Symbol = w2+"(kg)", SelfCoeffient = 1000, StandardCoeffient = 1, Classfication = "Metric" },
            new Unit { Name_Symbol = w3+"(mg)", SelfCoeffient = 1000000, StandardCoeffient = 1, Classfication = "Metric" },
            new Unit { Name_Symbol = w4+"(t)", SelfCoeffient = 1, StandardCoeffient = 1000, Classfication = "Metric" },
            new Unit { Name_Symbol = w5+"(q)", SelfCoeffient = 1, StandardCoeffient = 100, Classfication = "Metric" },
            new Unit { Name_Symbol = w6+"(lb)", SelfCoeffient = 1, StandardCoeffient = 1, Classfication = "British" },
            new Unit { Name_Symbol = w7+"(oz)", SelfCoeffient = 16, StandardCoeffient = 1, Classfication = "British" },

        };
        public static UnitList WeightUnits = new UnitList(0.45359237,0,0,weight);
        #endregion

        #region Length
        private static List<Unit> length = new List<Unit>
        {            
            new Unit { Name_Symbol = l1+"(m)", SelfCoeffient = 1, StandardCoeffient = 1, Classfication = "Metric" },
            new Unit { Name_Symbol = l2+"(km)", SelfCoeffient = 1, StandardCoeffient = 1000, Classfication = "Metric" },
            new Unit { Name_Symbol = l3+"(dm)", SelfCoeffient = 10, StandardCoeffient = 1, Classfication = "Metric" },
            new Unit { Name_Symbol = l4+"(cm)", SelfCoeffient = 100, StandardCoeffient = 1, Classfication = "Metric" },
            new Unit { Name_Symbol = l5+"(mm)", SelfCoeffient = 1000, StandardCoeffient = 1, Classfication = "Metric" },
            new Unit { Name_Symbol = l6+"(μm)", SelfCoeffient = 1000000, StandardCoeffient = 1, Classfication = "Metric" },
            new Unit { Name_Symbol = l7+"(NM)", SelfCoeffient = 1, StandardCoeffient = 1852, Classfication = "Metric" },
            new Unit { Name_Symbol = l8+"(ft)", SelfCoeffient = 1, StandardCoeffient = 1, Classfication = "British" },
            new Unit { Name_Symbol = l9+"(in)", SelfCoeffient = 12, StandardCoeffient = 1, Classfication = "British" },
            new Unit { Name_Symbol = l10+"(yd)", SelfCoeffient = 1, StandardCoeffient = 3, Classfication = "British" },
            new Unit { Name_Symbol = l11+"(mile)", SelfCoeffient = 1, StandardCoeffient = 5280, Classfication = "British" },
            
        };
        public static UnitList LengthUnits = new UnitList(0.3048, 0, 0, length);
        #endregion
        
        #region Area
        private static List<Unit> area = new List<Unit>
        {            
            new Unit { Name_Symbol = a1+"(m²)", SelfCoeffient = 1, StandardCoeffient = 1, Classfication = "Metric" },
            new Unit { Name_Symbol = a2+"(dm²)", SelfCoeffient = 100, StandardCoeffient = 1, Classfication = "Metric" },
            new Unit { Name_Symbol = a3+"(cm²)", SelfCoeffient = 10000, StandardCoeffient = 1, Classfication = "Metric" },
            new Unit { Name_Symbol = a4+"(mm²)", SelfCoeffient = 1000000, StandardCoeffient = 1, Classfication = "Metric" },
            new Unit { Name_Symbol = a5+"(km²)", SelfCoeffient = 1, StandardCoeffient = 1000000, Classfication = "Metric" },

        };
        public static UnitList AreaUnits = new UnitList(0.09290304, 0, 0, area);
        #endregion

        #region Volume
        private static List<Unit> volume = new List<Unit>
        {            
            new Unit { Name_Symbol = v1+"(L)", SelfCoeffient = 1, StandardCoeffient = 1, Classfication = "Metric" },
            new Unit { Name_Symbol = v2+"(m³)", SelfCoeffient = 1, StandardCoeffient = 1000, Classfication = "Metric" },
            new Unit { Name_Symbol = v3+"(cm³)", SelfCoeffient = 1000, StandardCoeffient = 1, Classfication = "Metric" },
            new Unit { Name_Symbol = v4+"(mm³)", SelfCoeffient = 1000000, StandardCoeffient = 1, Classfication = "Metric" },
            new Unit { Name_Symbol = v5+"(mL)", SelfCoeffient = 1000, StandardCoeffient = 1, Classfication = "Metric" },
            new Unit { Name_Symbol = v6+"(US pt)", SelfCoeffient = 1, StandardCoeffient = 1, Classfication = "American" },
            new Unit { Name_Symbol = v7+"(US qt)", SelfCoeffient = 1, StandardCoeffient = 2, Classfication = "American" },
            new Unit { Name_Symbol = v8+"(US gal)", SelfCoeffient = 1, StandardCoeffient = 8, Classfication = "American" },

        };
        public static UnitList VolumeUnits = new UnitList(28.3168,0.56826125,0.55061047,volume);
        #endregion

        #region Energy
        private static List<Unit> energy = new List<Unit>
        {            
            new Unit { Name_Symbol = e1+"(J)", SelfCoeffient = 1, StandardCoeffient = 1, Classfication = "Metric" },
            new Unit { Name_Symbol = e2+"卡(cal)", SelfCoeffient = 1, StandardCoeffient = 4.185851820846, Classfication = "Metric" },
            new Unit { Name_Symbol = e3+"千卡(kcal)", SelfCoeffient = 1, StandardCoeffient = 4185.851820846, Classfication = "Metric" },

        };
        public static UnitList EnergyUnits = new UnitList(0, 0, 0, energy);
        #endregion

        public void ChangeLanguage()
        {
            if (MyGlobals.Total == 1)
            {
                w1 = "";
                w2 = "";
                w3 = "";
                w4 = "";
                w5 = "";
                w6 = "";
                w7 = "";

                a1 = "";
                a2 = "";
                a3 = "";
                a5 = "";

                l1 = "";
                l2 = "";
                l3 = "";
                l4 = "";
                l5 = "";
                l6 = "";
                l7 = "";
                l8 = "";
                l9 = "";
                l10 = "";
                l11 = "";

                e1 = "";
                e2 = "";
                e3 = "";

                v1 = "";
                v2 = "";
                v3 = "";
                v4 = "";
                v6 = "";
                v5 = "";
                v7 = "";
                v8 = "";

                d = "";
                r = "";
            }
            else if(MyGlobals.Total==2)
            {
                w1 = "";
                w2 = "";
                w3 = "";
                w4 = "";
                w5 = "";
                w6 = "";
                w7 = "";

                a1 = "";
                a2 = "";
                a3 = "";
                a5 = "";

                l1 = "";
                l2 = "";
                l3 = "";
                l4 = "";
                l5 = "";
                l6 = "";
                l7 = "";
                l8 = "";
                l9 = "";
                l10 = "";
                l11 = "";

                e1 = "";
                e2 = "";
                e3 = "";

                v1 = "";
                v2 = "";
                v3 = "";
                v4 = "";
                v6 = "";
                v5 = "";
                v7 = "";
                v8 = "";

                d = "";
                r = "";
            }else if (MyGlobals.Total==3)
            {
                w1 = "";
                w2 = "";
                w3 = "";
                w4 = "";
                w5 = "";
                w6 = "";
                w7 = "";

                a1 = "";
                a2 = "";
                a3 = "";
                a5 = "";

                l1 = "";
                l2 = "";
                l3 = "";
                l4 = "";
                l5 = "";
                l6 = "";
                l7 = "";
                l8 = "";
                l9 = "";
                l10 = "";
                l11 = "";

                e1 = "";
                e2 = "";
                e3 = "";

                v1 = "";
                v2 = "";
                v3 = "";
                v4 = "";
                v6 = "";
                v5 = "";
                v7 = "";
                v8 = "";

                d = "";
                r = "";
            }
            else
            {
                w1 = "";
                w2 = "";
                w3 = "";
                w4 = "";
                w5 = "";
                w6 = "";
                w7 = "";

                a1 = "";
                a2 = "";
                a3 = "";
                a5 = "";

                l1 = "";
                l2 = "";
                l3 = "";
                l4 = "";
                l5 = "";
                l6 = "";
                l7 = "";
                l8 = "";
                l9 = "";
                l10 = "";
                l11 = "";

                e1 = "";
                e2 = "";
                e3 = "";

                v1 = "";
                v2 = "";
                v3 = "";
                v4 = "";
                v6 = "";
                v5 = "";
                v7 = "";
                v8 = "";

                d = "";
                r = "";
            }
        }

        #region Angle
        private static List<Unit> angle = new List<Unit>
        {            
            new Unit { Name_Symbol = d+"(°)", SelfCoeffient = 1, StandardCoeffient = 1, Classfication = "Metric" },
            new Unit { Name_Symbol = r+"(rad)", SelfCoeffient = 1, StandardCoeffient = 57.29577944, Classfication = "Metric" },
            
        };
        public static UnitList AngleUnits = new UnitList(0.3048, 0, 0, angle);
        #endregion

        #region Power
        private static List<Unit> power = new List<Unit>
        {            
            new Unit { Name_Symbol = "瓦(W)", SelfCoeffient = 1, StandardCoeffient = 1, Classfication = "Metric" },
            new Unit { Name_Symbol = "千瓦(kW)", SelfCoeffient = 1, StandardCoeffient = 1000, Classfication = "Metric" },
            new Unit { Name_Symbol = "焦耳/秒(J/s)", SelfCoeffient = 1, StandardCoeffient = 1, Classfication = "Metric" },
            new Unit { Name_Symbol = "美制马力(PS)", SelfCoeffient = 1, StandardCoeffient = 735.49875, Classfication = "Metric" },
            new Unit { Name_Symbol = "公斤▪米/秒(kg▪m/s)", SelfCoeffient = 1, StandardCoeffient = 9.80665, Classfication = "Metric" },
            new Unit { Name_Symbol = "千卡/秒(kcal/s)", SelfCoeffient = 1, StandardCoeffient = 4184.1004, Classfication = "Metric" },
            new Unit { Name_Symbol = "英制马力(HP)", SelfCoeffient = 1, StandardCoeffient = 1, Classfication = "British" },
            new Unit { Name_Symbol = "英尺▪磅/秒(ft▪lb/s)", SelfCoeffient = 550, StandardCoeffient = 1, Classfication = "British" },
        };
        public static UnitList PowerUnits = new UnitList(745.699872, 0, 0, power);
        #endregion

        #region Pressure
        private static List<Unit> pressure = new List<Unit>
        {
            new Unit { Name_Symbol = "帕斯卡(Pa)", SelfCoeffient = 1, StandardCoeffient = 1, Classfication = "Metric" },
            new Unit { Name_Symbol = "千帕(KPa)", SelfCoeffient = 1, StandardCoeffient = 1000, Classfication = "Metric" },
            new Unit { Name_Symbol = "兆帕(MPa)", SelfCoeffient = 1, StandardCoeffient = 1000000, Classfication = "Metric" },
            new Unit { Name_Symbol = "工程大气压(kgf/cm²)", SelfCoeffient = 1, StandardCoeffient = 98066.5, Classfication = "Metric" },
            new Unit { Name_Symbol = "巴(bar)", SelfCoeffient = 1, StandardCoeffient = 100000, Classfication = "Metric" },
            new Unit { Name_Symbol = "公斤/平方米(kg/m²)", SelfCoeffient = 1, StandardCoeffient = 9.80665, Classfication = "Metric" },
            new Unit { Name_Symbol = "磅/平方英寸(psi)", SelfCoeffient = 1, StandardCoeffient = 6894.757, Classfication = "Metric" },
            new Unit { Name_Symbol = "标准大气压(atm)", SelfCoeffient = 1, StandardCoeffient = 1, Classfication = "British" },
            new Unit { Name_Symbol = "毫米汞柱(mmHg)", SelfCoeffient = 760, StandardCoeffient = 1, Classfication = "British" },
        };
        public static UnitList PressureUnits = new UnitList(101325, 0, 0, pressure);
        #endregion

        #region Temperature
        private static List<Unit> temperature = new List<Unit>
        {            
            new Unit { Name_Symbol = "摄氏度(℃)", SelfCoeffient = 1, StandardCoeffient = 1, Classfication = "Metric" },
            new Unit { Name_Symbol = "华氏度(℉)", SelfCoeffient = 1, StandardCoeffient = 1, Classfication = "Metric" },
            new Unit { Name_Symbol = "兰氏度(°R)", SelfCoeffient = 1, StandardCoeffient = 1, Classfication = "Metric" },
            new Unit { Name_Symbol = "列氏度(°Re)", SelfCoeffient = 1, StandardCoeffient = 1, Classfication = "Metric" },
            new Unit { Name_Symbol = "开氏度(K)", SelfCoeffient = 1, StandardCoeffient = 1, Classfication = "Metric" }
        };
        public static UnitList TemperatureUnits = new UnitList(0, 0, 0, temperature);
        #endregion

        #region Velocity
        private static List<Unit> velocity = new List<Unit>
        {            
            new Unit { Name_Symbol = "米/秒(m/s)", SelfCoeffient = 1, StandardCoeffient = 1, Classfication = "Metric" },
            new Unit { Name_Symbol = "公里/小时(km/h)", SelfCoeffient = 3.6, StandardCoeffient = 1, Classfication = "Metric" },
            new Unit { Name_Symbol = "厘米/秒(cm/s)", SelfCoeffient = 100, StandardCoeffient = 1, Classfication = "Metric" },
            new Unit { Name_Symbol = "马赫(M)", SelfCoeffient = 1, StandardCoeffient = 340.3, Classfication = "Metric" },
            new Unit { Name_Symbol = "节(kts)", SelfCoeffient = 3600, StandardCoeffient = 1852, Classfication = "Metric" },
            new Unit { Name_Symbol = "英里/小时(mph)", SelfCoeffient = 1, StandardCoeffient = 1, Classfication = "British" },
            new Unit { Name_Symbol = "英尺/秒(ft/s)", SelfCoeffient = 5280, StandardCoeffient = 3600, Classfication = "British" },
        };
        public static UnitList VelocityUnits = new UnitList(0.44704, 0, 0, velocity);
        #endregion

    }
}
