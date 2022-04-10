import os
import sys
import wget

from colorama import Fore, Style
from zipfile import ZipFile
from tqdm import tqdm


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

        self.__status: bool = False

        self.__size_chrome_driver: int = None
        self.__filename_chromedriver: str = "chromedriver_win32.zip"
    
    @staticmethod
    def __bar_progress(current, total, width=80):
        progress_message = f"Downloading: [{'█' * int(current / total * 100)}{'.' * int(100 - (current / total * 100))}] {round((current / total * 100), 2)}% - {round((current / 1024.0 / 1024.0), 2)}MB"
        sys.stdout.write("\r" + progress_message)
        sys.stdout.flush()

    def __download_chrome_driver(self):
        if not os.path.exists(self.__CHROME_DRIVER_FOLDER):
            os.mkdir(self.__CHROME_DRIVER_FOLDER)

        question = input("\n(Pode ocorrer de drive não ser compátivel com o seu Chrome [Versão: 98.0.4758.80])\nVocê aceita a versão padrão do Chrome Driver para o projeto? (y/n) ")
        if question == 'y':
            print("\nGetting Chrome Driver")
            self.__filename_chromedriver = wget.download(self.__CHROME_DRIVER_LINK, self.__CHROME_DRIVER_FOLDER, bar=self.__bar_progress)
        else:
            print("\nGetting Chrome Driver")
            chromedriver_link = input(f"\nDigite o link do chromedriver ({Fore.BLUE}{Style.NORMAL}https://chromedriver.chromium.org/downloads{Style.RESET_ALL} pegue o seu link para download aqui 'DE ACORDO COM A VERSÃO DO SEU CHROME!'!): ")
            try: 
                self.__filename_chromedriver = wget.download(chromedriver_link, self.__CHROME_DRIVER_FOLDER, bar=self.__bar_progress)
            except ConnectionError as cn:
                print("\nErro de conexão ou link incorreto")
                exit(-1)
        print("\n")

    def __unzip_chromedriver(self):
        print("Extraindo Driver: ")
        file_name = ""
        with ZipFile(os.path.join(self.__CHROME_DRIVER_FOLDER, self.__filename_chromedriver), "r") as zip:
            for file in tqdm(iterable=zip.infolist(), total=len(zip.infolist()), desc="Files Qtd ", unit=""):
                file_name = file.filename
                zip.extract(member=file, path=self.__CHROME_DRIVER_FOLDER)

        if os.path.exists(os.path.join(self.__CHROME_DRIVER_FOLDER, self.__filename_chromedriver)):
            os.remove(os.path.join(self.__CHROME_DRIVER_FOLDER, self.__filename_chromedriver))

        self.__CHROME_DRIVER_PATH = os.path.join(self.__CHROME_DRIVER_FOLDER, file_name)
        print(f"\n\nDownload concluido, driver salvo na pasta {Fore.GREEN}{Style.BRIGHT}{self.__CHROME_DRIVER_PATH}{Style.RESET_ALL}")
        print(f"{Fore.RED}{Style.DIM}{'Não delete está pasta ou arquivo durante a instalação'.upper()}{Style.RESET_ALL}\n\n")

    def __mount_file_register(self, project_name, excutable_file_path, icon_path):
        pass

    def __registry_on_windows_register(self):
        pass

    def __compile_main_dot_py(self):
        pass

    def __move_project_to_program_files(self):
        pass

    def __download_files(self):
        pass

    def install(self):
        self.__download_chrome_driver()
        self.__unzip_chromedriver()


if __name__ == "__main__":
    installer = Installer()
    installer.install()
