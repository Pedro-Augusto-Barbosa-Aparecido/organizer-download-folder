import os
import sys

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
        self.__USER_DOWNLOADS_FOLDER = os.path.join(
            os.path.dirname(__file__),
            "main.exe"
        )

        if not self.__verify_exist_main_exe():
            print(Style.BRIGHT + Fore.RED + "Could not find main.exe" + Style.RESET_ALL)
            exit(0)

    def __mount_file_register(self, project_name, excutable_file_path, icon_path):
        pass

    def __registry_on_windows_register(self):
        pass

    def __compile_main_dot_py(self):
        pass

    def __move_project_to_program_files(self):
        pass

    def __verify_exist_main_exe(self):
        if os.path.isfile(self.__USER_DOWNLOADS_FOLDER):
            return True
        return False

    def install(self):
        pass


if __name__ == "__main__":
    installer = Installer()
