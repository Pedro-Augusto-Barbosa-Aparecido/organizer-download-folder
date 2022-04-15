import os
import shutil
import sys
import time


class FileNameManager:
    def __init__(self, file_list: list[str], base_dir: str) -> None:
        self.dict_file = {}
        
        self._file_list = file_list
        self._base_dir = base_dir

    def _get_keys(self):
        keys = {}
        for file in self._file_list:
            if os.path.isfile(os.path.join(self._base_dir, file)):
                finish = False
                index_dot = [-1]
                while not finish:
                    index_dot.append(file.find('.', (index_dot[-1] + 1)))
                    if index_dot[-1] == -1:
                        index = index_dot[-2] + 1
                        finish = True
                        if file[index:] in list(keys.keys()):
                            keys[file[index:]].append(file)
                        else:
                            keys[file[index:]] = [file]
        
        return keys


class FileMoveManager:
    def __init__(
        self, 
        files: dict[str, list[str]], 
        folders: list[str], 
        base_dir: str
    ) -> None:
        self._files_with_destination = files
        self._base_dir = base_dir
        self._folders = folders

    def test(self):
        pass

    def move_files(self):
        for folder in self._folders:
            files = self._files_with_destination[folder]
            for file in files:
                shutil.move(
                    os.path.join(self._base_dir, file), 
                    os.path.join(self._base_dir, folder, file)
                )


class Organizer:
    __USER_FOLDER = os.path.expanduser("~")
    __USER_DOWNLOADER_FOLDER = os.path.join(__USER_FOLDER, "Downloads")

    def __init__(self) -> None:
        self.__path_of_execution = sys.argv[1].replace('.', '').replace('\\', '\\\\')
        self._files = FileNameManager(self._get_files(), self.__path_of_execution)
        self.file_movier = None
        self._folders = []

        self._create_folders(list(self._files._get_keys().keys()))

    def _create_folders(self, folder_output: list[str]):
        for folder in folder_output:
            if not os.path.isdir(os.path.join(self.__path_of_execution, folder)) and \
               not os.path.exists(os.path.join(self.__path_of_execution, folder)):
                os.mkdir(os.path.join(self.__path_of_execution, folder))
                self._folders.append(folder)

    def _get_files(self):
        return os.listdir(self.__path_of_execution)
        
    def move_files(self):
        if len(self._folders) == 0:
            self._folders = self._files._get_keys().keys()
        self.file_movier = FileMoveManager(
            self._files._get_keys(),
            self._folders,
            self.__path_of_execution
        )
        self.file_movier.move_files()
