using AutoMapper;
using HZH_Controls;
using HZH_Controls.Controls;
using HZH_Controls.Forms;
using QualityCheckDemo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkersGaugeTrace;

namespace MachineryProcessingDemo
{
    public partial class MainPanel : FrmBase
    {
        public MainPanel()
        {
            InitializeComponent();
        }

        //图标间宽度
        private static int _widthX = 900;
        //tuple计数器
        private static int _tupleI = 0;
        //全局静态只读tuple
        private static readonly List<Tuple<string, string>> MuneList = new List<Tuple<string, string>>()
        {
            new Tuple<string, string>("绑定", "E_arrow_carrot_2up_alt"),
            new Tuple<string, string>("退出", "A_fa_power_off"),
        };

        private void MainPanel_Load(object sender, EventArgs e)
        {
            // var dateTime = context.GetServerDate();
            //使用hzh控件自带的图标库 tuple

            //解析tuple 加载顶部菜单栏 绑定事件

            InialLabel();

            InitialColumns();

            // var kitDtos = GetDetail();
            // // ucDataGridView1.DataSource = kitDtos;
            // var list = kitDtos.Take(9).ToList();
            // var objects = new List<object>();
            // objects.AddRange(list);
            //
            // var ucPagerControl = new UCPagerControl2();
            // panel1.Controls.Add(ucPagerControl);
            //
            // ucPagerControl.Location = new Point(panel1.Width / 2 - ucPagerControl.Width / 2, 0);
            // ucPagerControl.PageSize = 9;
            // ucPagerControl.StartIndex = 0;
            // ucPagerControl.DataSource = objects;
            // ucDataGridView1.DataSource = ucPagerControl.DataSource; 
            // ucPagerControl.FirstPage();
            // var currentSource = ucPagerControl.GetCurrentSource();

            InitialDidTasks();

            ucSignalLamp1.LampColor = new Color[] { Color.Green };
            ucSignalLamp2.LampColor = new Color[] { Color.Red };

            timer1.Enabled = true;

            IsFullSize = false;
        }

        private async void InialLabel()
        {
            var onlineLabel = await GenerateLabel();
            FirstTitlePanel.Controls.Add(onlineLabel);
            onlineLabel.Click += OpenScanOnlineForm;

            var exitLabel = await GenerateLabel();
            FirstTitlePanel.Controls.Add(exitLabel);
            exitLabel.Click += CloseForms;
        }

        private void InitialColumns()
        {
            // 自定义表格 装载图片等资源
            List<DataGridViewColumnEntity> lstColumns = new List<DataGridViewColumnEntity>
            {
                new DataGridViewColumnEntity()
                {
                    DataField = "KitBornCode", HeadText = "工量具编号", Width = 20, WidthType = SizeType.Percent
                },
                new DataGridViewColumnEntity()
                {
                    DataField = "KitName", HeadText = "工量具名称", Width = 20, WidthType = SizeType.Percent
                },
                new DataGridViewColumnEntity()
                {
                    DataField = "ApplicanceType", HeadText = "工量具类型", Width = 10, WidthType = SizeType.Percent
                } ,
                new DataGridViewColumnEntity()
                {
                    DataField = "PositionName", HeadText = "工量具位置", Width = 20, WidthType = SizeType.Percent
                },
                new DataGridViewColumnEntity()
                {
                    DataField = "StaffName", HeadText = "使用者", Width = 15, WidthType = SizeType.Percent
                },   new DataGridViewColumnEntity()
                {
                    DataField = "Reserve1", HeadText = "工量具状态", Width = 15, WidthType = SizeType.Percent
                },
            };
            ucDataGridView1.Columns = lstColumns;
        }

        private void OpenScanOnlineForm(object sender, EventArgs e)
        {
            var workerGauge = new WorkerGauge
            {
                BackColor = Color.FromArgb(200, 200, 247),
                RegetAction = () => InitialDidTasks()
            };
            workerGauge.ShowDialog();
        }

        private async void InitialDidTasks()
        {
            ucDataGridView1.DataSource = await GetDidProcedureTask();
        }

        private async Task<List<KitDto>> GetDidProcedureTask()
        {
            return await GetDetailAsync();
        }

        private async Task<List<KitDto>> GetDetailAsync()
        {
            var kitProcessingDocuments = new List<KitDto>();
            using (var context = new Model())
            {
                await Task.Run(() =>
                {
                    var mapperConfiguration = new MapperConfiguration(cfg =>
                        cfg.CreateMap<KitProcessingDocument, KitDto>());
                    var mapper = mapperConfiguration.CreateMapper();

                    var mapperConfiguration1 = new MapperConfiguration(cfg =>
                        cfg.CreateMap<C_KitProcessing, KitDto>());
                    var mapper1 = mapperConfiguration1.CreateMapper();

                    var list = new List<string>();
                    var cKitProcessings = context.C_KitProcessing.ToList();
                    foreach (var cKitProcessing in cKitProcessings)
                    {
                        var kitDto = mapper1.Map<KitDto>(cKitProcessing);
                        kitDto.ID = (int)kitDto.KitID;
                        kitDto.ApplicanceType = cKitProcessing.ApplianceType;
                        kitDto.KitBornCode = kitDto.KitCode;
                        kitProcessingDocuments.Add(kitDto);
                        list.Add(cKitProcessing.KitCode);
                    }

                    var processingDocuments = context.KitProcessingDocument.ToList();

                    foreach (var kitProcessingDocument in processingDocuments)
                    {
                        if (list.Contains(kitProcessingDocument.KitBornCode))
                        {
                            continue;
                        }
                        var kitDto = mapper.Map<KitDto>(kitProcessingDocument);
                        kitDto.KitID = kitDto.ID;
                        kitDto.KitCode = kitDto.KitBornCode;
                        kitProcessingDocuments.Add(kitDto);
                    }
                });
                return kitProcessingDocuments;
            }
        }
        private List<KitDto> GetDetail()
        {
            using (var context = new Model())
            {
                var kitProcessingDocuments = new List<KitDto>();
                var mapperConfiguration = new MapperConfiguration(cfg =>
                    cfg.CreateMap<KitProcessingDocument, KitDto>());
                var mapper = mapperConfiguration.CreateMapper();

                var mapperConfiguration1 = new MapperConfiguration(cfg =>
                    cfg.CreateMap<C_KitProcessing, KitDto>());
                var mapper1 = mapperConfiguration1.CreateMapper();

                var list = new List<string>();
                var cKitProcessings = context.C_KitProcessing.ToList();
                foreach (var cKitProcessing in cKitProcessings)
                {
                    var kitDto = mapper1.Map<KitDto>(cKitProcessing);
                    kitDto.ID = (int)kitDto.KitID;
                    kitDto.ApplicanceType = cKitProcessing.ApplianceType;
                    kitDto.KitBornCode = kitDto.KitCode;
                    kitProcessingDocuments.Add(kitDto);
                    list.Add(cKitProcessing.KitCode);
                }

                var processingDocuments = context.KitProcessingDocument.ToList();

                foreach (var kitProcessingDocument in processingDocuments)
                {
                    if (list.Contains(kitProcessingDocument.KitBornCode))
                    {
                        continue;
                    }
                    var kitDto = mapper.Map<KitDto>(kitProcessingDocument);
                    kitDto.KitID = kitDto.ID;
                    kitDto.KitCode = kitDto.KitBornCode;
                    kitProcessingDocuments.Add(kitDto);
                }
                return kitProcessingDocuments;
            }

        }
        private void CloseForms(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private async Task<Label> GenerateLabel()
        {
            var label = new Label();
            await Task.Run((() =>
            {
                var icon = (FontIcons)Enum.Parse(typeof(FontIcons), MuneList[_tupleI].Item2);

                label.AutoSize = false;
                label.Size = new Size(90, 60);
                label.ForeColor = Color.White;
                label.TextAlign = ContentAlignment.BottomCenter;
                label.ImageAlign = ContentAlignment.TopCenter;
                label.Margin = new Padding(5);
                label.Text = MuneList[_tupleI].Item1;
                label.Image = FontImages.GetImage(icon, 32, Color.White);
                label.Location = new Point(_widthX, 0);
                label.Font = new Font("微软雅黑", 12, FontStyle.Bold);
                _widthX += 90;
                _tupleI++;
            }));
            return label;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            ucDataGridView1.DataSource = GetSomething();
        }

        private void ucBtnExt1_BtnClick(object sender, EventArgs e)
        {
            ucDataGridView1.DataSource = GetSomething();
        }

        private List<KitDto> GetByKitCode()
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                return GetDetail();
            }
            using (var context = new Model())
            {
                var kitProcessingDocuments = new List<KitDto>();
                var list = new List<string>();

                var mapperConfiguration1 = new MapperConfiguration(cfg =>
                    cfg.CreateMap<C_KitProcessing, KitDto>());
                var mapper1 = mapperConfiguration1.CreateMapper();
                var mapperConfiguration = new MapperConfiguration(cfg =>
                    cfg.CreateMap<KitProcessingDocument, KitDto>());
                var mapper = mapperConfiguration.CreateMapper();

                var cKitProcessings = context.C_KitProcessing.Where(s => s.KitCode.Contains(textBox1.Text.Trim())).ToList();
                foreach (var cKitProcessing in cKitProcessings)
                {
                    var kitDto = mapper1.Map<KitDto>(cKitProcessing);
                    kitDto.ID = (int)kitDto.KitID;
                    kitDto.ApplicanceType = cKitProcessing.ApplianceType;
                    kitDto.KitBornCode = kitDto.KitCode;
                    kitProcessingDocuments.Add(kitDto);
                    list.Add(cKitProcessing.KitCode);
                }

                var processingDocuments = context.KitProcessingDocument.Where(s => s.KitBornCode.Contains(textBox1.Text.Trim())).ToList();
                foreach (var kitProcessingDocument in processingDocuments)
                {
                    if (list.Contains(kitProcessingDocument.KitBornCode))
                    {
                        continue;
                    }
                    var kitDto = mapper.Map<KitDto>(kitProcessingDocument);
                    kitDto.KitID = kitDto.ID;
                    kitDto.KitCode = kitDto.KitBornCode;
                    kitProcessingDocuments.Add(kitDto);
                }
                return kitProcessingDocuments;
            }
        }

        private List<KitDto> GetByKitType()
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                return GetDetail();
            }
            using (var context = new Model())
            {
                var kitProcessingDocuments = new List<KitDto>();
                var list = new List<string>();

                var mapperConfiguration1 = new MapperConfiguration(cfg =>
                    cfg.CreateMap<C_KitProcessing, KitDto>());
                var mapper1 = mapperConfiguration1.CreateMapper();
                var mapperConfiguration = new MapperConfiguration(cfg =>
                    cfg.CreateMap<KitProcessingDocument, KitDto>());
                var mapper = mapperConfiguration.CreateMapper();

                int applicationType = "刀具".Contains(textBox1.Text.Trim()) ? (int)ApplianceType.Tooling :
                    "量具".Contains(textBox1.Text.Trim()) ? (int)ApplianceType.Measuring : 0;
                if (applicationType == 0)
                {
                    return GetDetail();
                }
                var cKitProcessings = context.C_KitProcessing.Where(s => s.ApplianceType == applicationType).ToList();
                foreach (var cKitProcessing in cKitProcessings)
                {
                    var kitDto = mapper1.Map<KitDto>(cKitProcessing);
                    kitDto.ID = (int)kitDto.KitID;
                    kitDto.ApplicanceType = cKitProcessing.ApplianceType;
                    kitDto.KitBornCode = kitDto.KitCode;
                    kitProcessingDocuments.Add(kitDto);
                    list.Add(cKitProcessing.KitCode);
                }

                var processingDocuments = context.KitProcessingDocument.Where(s => s.ApplicanceType == applicationType).ToList();
                foreach (var kitProcessingDocument in processingDocuments)
                {
                    if (list.Contains(kitProcessingDocument.KitBornCode))
                    {
                        continue;
                    }
                    var kitDto = mapper.Map<KitDto>(kitProcessingDocument);
                    kitDto.KitID = kitDto.ID;
                    kitDto.KitCode = kitDto.KitBornCode;
                    kitProcessingDocuments.Add(kitDto);
                }
                return kitProcessingDocuments;
            }
        }

        private List<KitDto> GetByKitName()
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                return GetDetail();
            }
            using (var context = new Model())
            {
                var kitProcessingDocuments = new List<KitDto>();
                var list = new List<string>();

                var mapperConfiguration1 = new MapperConfiguration(cfg =>
                    cfg.CreateMap<C_KitProcessing, KitDto>());
                var mapper1 = mapperConfiguration1.CreateMapper();
                var mapperConfiguration = new MapperConfiguration(cfg =>
                    cfg.CreateMap<KitProcessingDocument, KitDto>());
                var mapper = mapperConfiguration.CreateMapper();

                var cKitProcessings = context.C_KitProcessing.Where(s => s.KitName.Contains(textBox1.Text.Trim())).ToList();
                foreach (var cKitProcessing in cKitProcessings)
                {
                    var kitDto = mapper1.Map<KitDto>(cKitProcessing);
                    kitDto.ID = (int)kitDto.KitID;
                    kitDto.ApplicanceType = cKitProcessing.ApplianceType;
                    kitDto.KitBornCode = kitDto.KitCode;
                    kitProcessingDocuments.Add(kitDto);
                    list.Add(cKitProcessing.KitCode);
                }

                var processingDocuments = context.KitProcessingDocument.Where(s => s.KitName.Contains(textBox1.Text.Trim())).ToList();
                foreach (var kitProcessingDocument in processingDocuments)
                {
                    if (list.Contains(kitProcessingDocument.KitBornCode))
                    {
                        continue;
                    }
                    var kitDto = mapper.Map<KitDto>(kitProcessingDocument);
                    kitDto.KitID = kitDto.ID;
                    kitDto.KitCode = kitDto.KitBornCode;
                    kitProcessingDocuments.Add(kitDto);
                }
                return kitProcessingDocuments;
            }
        }
        private List<KitDto> GetSomething()
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                return GetDetail();
            }
            using (var context = new Model())
            {
                if (comboBox1.Text.Equals("全部"))
                {
                    return GetDetail();
                }
                else if (comboBox1.Text.Equals("工量具编号"))
                {
                    return GetByKitCode();
                }
                else if (comboBox1.Text.Equals("工量具类型"))
                {
                    return GetByKitType();
                }
                else
                {
                    return GetByKitName();
                }
            }
        }
    }
}
