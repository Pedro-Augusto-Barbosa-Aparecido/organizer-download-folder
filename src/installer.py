import os
import shutil
import sys
from time import sleep
import wget

from colorama import Fore, Style
from zipfile import ZipFile
from tqdm import tqdm

from selenium import webdriver
from webdriver_manager.chrome import ChromeDriverManager
from selenium.webdriver.chrome.service import Service
from PyInstaller.config import CONF


class Installer:
    # Property Is the content of Windows File Registry
    #
    # """
    #     Windows Registry Editor Version 5.00

    #     [HKEY_CLASSES_ROOT\\Directory\\Background\\shell\\{project_name}]
    #     @="Organizar pasta aqui..."
    #     "Icon"="{icon_path}"

    #     [HKEY_CLASSES_ROOT\Directory\Background\shell\{project_name}\command]
    #     @="\"{excutable_file_path}\" \"%v.\""
    
    # """

    def __init__(self, chromedriver_link: str = None) -> None:
        self.__USER_DOWNLOADS_FOLDER = os.path.join(os.path.expanduser("~"), "Dowmloads")
        self.__CURRENT_FOLDER = os.path.dirname(sys.executable)
        self.__PROGRAM_FILE_X86_FOLDER = os.environ.get("ProgramFiles(x86)")
        self.__CHROME_DRIVER_LINK = "https://chromedriver.storage.googleapis.com/98.0.4758.80/chromedriver_win32.zip"
        self.__CHROME_DRIVER_FOLDER = os.path.join(os.path.expanduser("~"), "Documents\\Organizer")
        self.__CHROME_DRIVER_PATH = ""
        self.__PROJECT_ZIP_LINK = "https://github.com/Pedro-Augusto-Barbosa-Aparecido/organizer-download-folder/archive/refs/heads/prod.zip"

        self.__status: bool = False

        self.__size_chrome_driver: int = None
        self.__filename_chromedriver: str = "chromedriver_win32.zip"
    
    @staticmethod
    def __bar_progress(current, total, width=80):
        progress_message = f"Downloading: [{'█' * int(current / total * 100)}{'.' * int(100 - (current / total * 100))}] {round((current / total * 100), 2)}% - {round((current / 1024.0 / 1024.0), 2)}MB"
        sys.stdout.write("\r" + progress_message)
        sys.stdout.flush()

    # def __download_chrome_driver(self):
    #     """
    #         Deprecated Function, but this function download chromedriver by https://chromedriver.storage.googleapis.com/
    #     """
    #     if not os.path.exists(self.__CHROME_DRIVER_FOLDER):
    #         os.mkdir(self.__CHROME_DRIVER_FOLDER)

    #     question = input("\n(Pode ocorrer de drive não ser compátivel com o seu Chrome [Versão: 98.0.4758.80])\nVocê aceita a versão padrão do Chrome Driver para o projeto? (y/n) ")
    #     if question == 'y':
    #         print("\nGetting Chrome Driver")
    #         self.__filename_chromedriver = wget.download(self.__CHROME_DRIVER_LINK, self.__CHROME_DRIVER_FOLDER, bar=self.__bar_progress)
    #     else:
    #         print("\nGetting Chrome Driver")
    #         chromedriver_link = input(f"\nDigite o link do chromedriver ({Fore.BLUE}{Style.NORMAL}https://chromedriver.chromium.org/downloads{Style.RESET_ALL} pegue o seu link para download aqui 'DE ACORDO COM A VERSÃO DO SEU CHROME!'!): ")
    #         try: 
    #             self.__filename_chromedriver = wget.download(chromedriver_link, self.__CHROME_DRIVER_FOLDER, bar=self.__bar_progress)
    #         except ConnectionError as cn:
    #             print("\nErro de conexão ou link incorreto")
    #             exit(-1)
    #     print("\n")

    def __unzip_chromedriver(self, filename: str):
        """
            Deprecated Function, but this function unzip chromedriver_win32.zip
        """
        try:
            print("Extraindo ZIP: ")
            file_name = ""
            with ZipFile(os.path.join(self.__CHROME_DRIVER_FOLDER, filename), "r") as zip:
                for file in tqdm(iterable=zip.infolist(), total=len(zip.infolist()), desc="Files Qtd ", unit=""):
                    file_name = file.filename
                    zip.extract(member=file, path=self.__CHROME_DRIVER_FOLDER)

            if os.path.exists(os.path.join(self.__CHROME_DRIVER_FOLDER, filename)):
                os.remove(os.path.join(self.__CHROME_DRIVER_FOLDER, filename))
            # if not os.path.exists(os.path.join(self.__CHROME_DRIVER_FOLDER, "drivers/chrome")):
            #     os.makedirs(os.path.join(self.__CHROME_DRIVER_FOLDER, "drivers/chrome"), exist_ok=True)

            # self.__CHROME_DRIVER_PATH = os.path.join(self.__CHROME_DRIVER_FOLDER, file_name)
            # shutil.move(self.__CHROME_DRIVER_PATH, os.path.join(self.__CHROME_DRIVER_FOLDER, "drivers\chrome"))
            # self.__CHROME_DRIVER_PATH = os.path.join(self.__CHROME_DRIVER_FOLDER, "drivers\chrome", file_name)
            print(f"\n\nDownload concluido, driver salvo na pasta {os.path.join(self.__CHROME_DRIVER_FOLDER, filename.replace('.zip', ''))}")
            print(f"{'Não delete está pasta ou arquivo durante a instalação'.upper()}\n\n")
        except Exception as e:
            print(e)
            print(f"Houve um erro durante a extração do driver, verifique se o diretório 'Documents', está com permissão livre para manipulaçãode arquivos!")
            exit(-1)

    def __mount_file_register(self, project_name, excutable_file_path, icon_path):
        self.__content_reg_file = f"""Windows Registry Editor Version 5.00

[HKEY_CLASSES_ROOT\\Directory\\Background\\shell\\{project_name}]
@="Organizar pasta aqui..."
"Icon"="{icon_path}"

[HKEY_CLASSES_ROOT\Directory\Background\shell\{project_name}\command]
@="\"{excutable_file_path}\" \"%v.\""
        
        """
        self.__organizer_path_reg = os.path.join(self.__CHROME_DRIVER_FOLDER, self.__filename_project.replace('.zip', ''), 'organizer.reg').replace('/', '\\')
        with open(self.__organizer_path_reg, 'w') as file_reg:
            file_reg.write(self.__content_reg_file)

        return self.__content_reg_file

    def __registry_on_windows_register(self):
        try:
            os.system(self.__organizer_path_reg)
        except Exception as e:
            print(e)

    def __compile_main_dot_py(self):
        try:
            self.__icon_path = os.path.join(self.__CHROME_DRIVER_FOLDER, self.__filename_project.replace('.zip', ''), 'app.ico').replace('/', '\\')
            self.__main_file = os.path.join(self.__CHROME_DRIVER_FOLDER, self.__filename_project.replace('.zip', ''), 'main.py').replace('/', '\\')
            
            # Configuração do diretório de output da pasta build e da pasta dist
            self.__build_folder = os.path.join(self.__CHROME_DRIVER_FOLDER, self.__filename_project.replace('.zip', ''), "build").replace('/', "\\")
            self.__dist_folder = os.path.join(self.__CHROME_DRIVER_FOLDER, self.__filename_project.replace('.zip', ''), "dist").replace('/', "\\")

            os.system(f'pyinstaller -c -F --icon={self.__icon_path} --distpath={self.__dist_folder} --workpath={self.__build_folder} {self.__main_file}')
        except:
            print(f"""
                Erro ao compilar arquivo {self.__main_file}
                """)

    def __install_requirements_txt(self):
        try:
            requirements_path = os.path.join(self.__CHROME_DRIVER_FOLDER, self.__filename_project.replace('.zip', ''), 'requirements.txt').replace('/', '\\')
            os.system(f"pip install -r {requirements_path}")
        except Exception as e:
            print(f"""Houve um erro durante a instalação dos subpacotes, 
                    verifique se o arquivo requirements.txt está na pasta 
                    {os.path.join(self.__CHROME_DRIVER_FOLDER, 'organizer-download-folder-master')}""")
            print(e)
            exit(-1)


    def __download_files(self):
        if not os.path.exists(self.__CHROME_DRIVER_FOLDER):
            os.mkdir(self.__CHROME_DRIVER_FOLDER)
        print(f"\nDownloding Files from {self.__PROJECT_ZIP_LINK}", end="")
        try: 
            print("")
            self.__filename_project = wget.download(self.__PROJECT_ZIP_LINK, self.__CHROME_DRIVER_FOLDER, bar=self.__bar_progress)
        except ConnectionError as cn:
            print("\nErro de conexão ou link incorreto")
            exit(-1)
        print("\n")

    def install(self):
        # self.__download_chrome_driver()
        self.__download_files()
        self.__unzip_chromedriver(self.__filename_project)
        self.__install_requirements_txt()
        self.__compile_main_dot_py()
        print(self.__mount_file_register("Organizer", os.path.join(self.__dist_folder, "main.exe"), self.__icon_path))
        self.__registry_on_windows_register()


if __name__ == "__main__":
    installer = Installer()
    installer.install()
