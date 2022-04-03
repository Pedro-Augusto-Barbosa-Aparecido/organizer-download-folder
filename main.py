import pprint
from src.organizer import Organizer, FileNameManager

organizer = Organizer()
organizer.move_files()
# file_list = ['20210825_151140.jpg',
#  '20210825_151209.jpg',
#  '20210916_224531.jpg',
#  '20210916_224556.jpg',
#  '20210916_224604.jpg',
#  '20210916_224609.jpg',
#  '20211006_201109.jpg',
#  '20211006_201127.jpg',
#  '20211006_201136.jpg',
#  '20211012_114812.jpg',
#  '20211012_114819.jpg',
#  '20211012_114839.jpg',
#  '20211013_185626.jpg',
#  '20211027_185515.jpg',
#  '20211027_190045.jpg',
#  '20211211_171727.jpg',
#  '20211211_171732.jpg',
#  '20211211_171739.jpg',
#  '20211211_171743.jpg',
#  '20211211_171749.jpg',
#  '20220125_200839.jpg',
#  '20220125_200901.jpg',
#  '20220125_201038.jpg',
#  '20220125_201116.jpg',
#  '20220125_201133.jpg',
#  '20220125_201202.jpg',
#  '20220125_201250.jpg',
#  '20220125_201318.jpg',
#  '20220125_201338.jpg',
#  '20220125_201407.jpg',
#  '20220125_201436.jpg',
#  '20220125_201520.jpg',
#  '20220125_201540.jpg',
#  '20220125_201631.jpg',
#  '20220125_201719.jpg',
#  '20220125_201903.jpg',
#  '20220125_201952.jpg',
#  '20220125_202017.jpg',
#  '20220125_202028.jpg',
#  '20220308_131305.jpg',
#  '20220308_131333.jpg',
#  '20220308_131347.jpg',
#  '20220308_131406.jpg',
#  '20220308_131426.jpg',
#  '20220308_131445.jpg',
#  '20220308_131456.jpg',
#  '20220308_131513.jpg',
#  '20220308_131529.jpg',
#  '5kplayer-setup.exe',
#  'alura-typer-inicial.zip',
#  'Anaconda3-2021.05-Windows-x86_64.exe',
#  'android-studio-2020.3.1.22-windows.exe',
#  'arduino-1.8.19-windows.exe',
#  'arduino-ide_2.0.0-rc5_Windows_64bit.exe',
#  'Arquivo20454_OCR.pdf',
#  'Atividade Desenho Universal.docx',
#  'AULA 02 (1).pdf',
#  'AULA 02.pdf',
#  'bfs (2).png',
#  'BlueStacksMicroInstaller_4.280.1.1002_native_de3f244f771cac48d1db7e431d19f365.exe',
#  'bootstrap-5.1.0-dist.zip',
#  'bootstrap-icons-1.8.1.zip',
#  'brpc_dev_outsourcing_database.xlsx',
#  'Capitulo_08 Momento Linear Impulso Colisoes.pdf',
#  'Capitulo_09 Movimento Circular.pdf',
#  'CareLinkUploader-ACC-7350-3-3-0-windows-installer (1).exe',
#  'CareLinkUploader-ACC-7350-3-3-0-windows-installer.exe',
#  'chromedriver_win32.zip',
#  'ChromeSetup.exe',
#  'CLion-2021.2.3.exe',
#  "Componentes SMD's.IntLib",
#  'desktop.ini',
#  'Disciplinas Pré-Eletivas Oferecidas -Eng. Software.pdf',
#  'Docker Desktop Installer (1).exe',
#  'Docker Desktop Installer.exe',
#  'dwdm-power-budget-tool-main.zip',
#  'EpicInstaller-13.0.0-enterprise.msi',
#  'ES - 1.1 - 08.12.2021.pdf',
#  'ES - 1.2 - 08.12.2021.pdf',
#  'EveLauncher-1972288.Qq0heh91TFqHGcbi1fkX4w.5IjLmXul54UVTy.exe',
#  'Executable',
#  'Export-Table-JSON-Data-To-Excel-jQuery-ExportToExcel.zip',
#  'Falcon C++-3.3.0.0-Setup.exe',
#  'favicon_io',
#  'favicon_io (1).zip',
#  'favicon_io.zip',
#  'FMCCJK.pdf',
#  'FreakyJSON_To_XLS (1).xlsx',
#  'FreakyJSON_To_XLS (10).xlsx',
#  'FreakyJSON_To_XLS (11).xlsx',
#  'FreakyJSON_To_XLS (12).xlsx',
#  'FreakyJSON_To_XLS (13).xlsx',
#  'FreakyJSON_To_XLS (14).xlsx',
#  'FreakyJSON_To_XLS (15).xlsx',
#  'FreakyJSON_To_XLS (16).xlsx',
#  'FreakyJSON_To_XLS (17).xlsx',
#  'FreakyJSON_To_XLS (18).xlsx',
#  'FreakyJSON_To_XLS (2).xlsx',
#  'FreakyJSON_To_XLS (3).xlsx',
#  'FreakyJSON_To_XLS (4).xlsx',
#  'FreakyJSON_To_XLS (5).xlsx',
#  'FreakyJSON_To_XLS (6).xlsx',
#  'FreakyJSON_To_XLS (7).xlsx',
#  'FreakyJSON_To_XLS (8).xlsx',
#  'FreakyJSON_To_XLS (9).xlsx',
#  'FreakyJSON_To_XLS.xlsx',
#  'game_assets',
#  'game_assets.zip',
#  'Git-2.33.0.2-64-bit.exe',
#  'go1.17.3.windows-amd64.msi',
#  'goland-2021.2.4.exe',
#  'Hình nền động Naruto.gif',
#  'icon.ico',
#  'ideaIU-2021.2.3.exe',
#  'imager_1.6.2.exe',
#  'imagesResized.png',
#  'imagesResized.v1.png',
#  'Insomnia.Core-2021.7.2.exe',
#  'Install League of Legends br.exe',
#  'JetBrains.Rider-2021.2.2.exe',
#  'JetBrainsMono-2.242',
#  'JetBrainsMono-2.242 (1).zip',
#  'JetBrainsMono-2.242.zip',
#  'Joao Antonio Aparecido 05-12-21 (1).pdf',
#  'Joao Antonio Aparecido 05-12-21 (2).pdf',
#  'Joao Antonio Aparecido 05-12-21.pdf',
#  'Joao Antonio Aparecido 18-01-22.pdf',
#  'KEPPNI V2 DRIVER',
#  'KEPPNI V2 DRIVER.rar',
#  'lib.zip',
#  'MicrosoftTeams-x64.msix',
#  'mingw-w64-v9.0.0.zip',
#  'Modern-Warfare-Setup.exe',
#  'mongodb-windows-x86_64-5.0.5-signed.msi',
#  'mota-master',
#  'mota-master.zip',
#  'mysql-installer-community-8.0.26.0.msi',
#  'node-v14.17.6-x64.msi',
#  'node-v16.13.1-x64 (1).msi',
#  'Notion Setup 2.0.23.exe',
#  'NP2 - Turma L6 - Pedro Augusto Barbosa Aparecido',
#  'NP2 - Turma L6 - Pedro Augusto Barbosa Aparecido.rar',
#  'NP2 - Turma L6 - Pedro Augusto Barbosa Aparecido.zip',
#  'NP2 - Turma L6 - Pedro Augusto Barbosa Aparecido1.zip',
#  'OneDrive_1_16-11-2021.zip',
#  'OneDrive_1_18-08-2021.zip',
#  'Pedro Augusto Barbosa Aparecido - 170 - 3Prova.pdf',
#  'phaser3-project-template-master.zip',
#  'PhpStorm-2021.2.3.exe',
#  'Planilha - Pedro Augusto.xlsx',
#  'Postman-win64-8.11.1-Setup.exe',
#  'programa__o_final_2016.ino',
#  'pycharm-community-2021.2.exe',
#  'pycharm-professional-2021.2.3.exe',
#  'pycharm-professional-2021.2.exe',
#  'python-3.10.0rc1-amd64.exe',
#  'python-3.10.2-amd64.exe',
#  'qt-unified-windows-x86-4.1.1-online.exe',
#  'query.iqy',
#  'Relatório 3 - Pedro Augusto .pdf',
#  'robo3t-1.4.4-windows-x86_64-e6ac9ec5.exe',
#  'RubyMine-2021.2.3.exe',
#  'rustup-init.exe',
#  'SADES_Scythe_Setup_v.2.0.2018(Win7,8,10).exe',
#  'Sasuke_epi_319.webp',
#  'ScpToolkit_Setup.exe',
#  'SEFITEL - Recorte Temático.docx',
#  'sqlite-icon-211633',
#  'sqlite-icon-211633.zip',
#  'sqlitestudio-3.3.3.zip',
#  'SteamSetup.exe',
#  'studio-3t-x64',
#  'studio-3t-x64.zip',
#  'Tabela de Diretivas.pdf',
#  'Tabelas_Conectivos_Equivalencia_Inferencia.pdf',
#  'Teams_windows_x64.exe',
#  'UnityHubSetup.exe',
#  'unreal-vr-arquitetura-parte-1-master.zip',
#  'user_report (1).xlsx',
#  'user_report (2).xlsx',
#  'user_report (3).xlsx',
#  'user_report.xlsx',
#  'VC_redist.x64.exe',
#  'VSCodeUserSetup-x64-1.59.0.exe',
#  'vs_BuildTools.exe',
#  'vs_community__rid.30001.exe',
#  'WebStorm-2021.2.3.exe',
#  'WhatsApp Image 2022-01-25 at 19.56.44.jpeg',
#  'WindowsPCHealthCheckSetup.msi',
#  'windows_11_cursors_concept_v2_by_rosea92_densjkc.zip',
#  'winrar-x64-602.exe', 'wsl_update_x64.msi',
#  'Zd69Y8kgRySH1aweiHAex0pwzD5cdSeHKZoWotPJ.rar']

# file_manager = FileNameManager(file_list, "C:\\Users\\pedro\\Downloads")
# pprint.pprint(file_manager._get_keys())