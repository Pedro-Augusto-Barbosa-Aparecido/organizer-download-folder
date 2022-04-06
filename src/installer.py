import os
import sys
import time

from colorama import Style, Fore


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

    def __init__(self) -> None:
        self.__program_files_folders = os.environ["ProgramFiles(x86)"]
        self.__USER_DOWNLOADS_FOLDER = os.path.join(os.path.expanduser("~"), "Downloads")
        self.__current_folder = os.path.dirname(sys.executable)

        self.__status: bool = False

    def __mount_file_register(self, project_name, excutable_file_path, icon_path):
        pass

    def __registry_on_windows_register(self):
        pass

    def __compile_main_dot_py(self):
        pass

    def __move_project_to_program_files(self):
        pass

    def install(self):
        pass


if __name__ == "__main__":
    installer = Installer()
