# kp_task11_files
Задание до вторника 30.05. Все остальные домашки сдать до этого же числа. Семинар 18.05 будет для тех, у кого есть какие-то вопросы. Если вопросов нет, можно не приходить.
На зачет я дам список вопросов и время, чтобы, используя все доступные средства, подготовиться к ответу. Наличие допуска к зачету смотрите в таблице посещаемости.
****
**Задание**  
Написать графическое приложение на Windows Forms / Wpf, которое позволит:

- Создавать текстовый файл по указанному пути;   
- Записывать в него текст, внесённый в элемент TextBox;  
- Читать текстовый файл из указанного пути. Отображать текст из файла в TextBox/TextBlock;  
- Добавить функции:  
-- Подсчет общего числа строк в файле;  
-- Подсчет числа строк, отвечающих заданному условию;  
-- Подсчет частоты появления заданного символа/слова;  
-- Замена заданного слова/символа другим словом/символом (аналог ctrl+h);  
-- Приведение всего текста илли найденного слова в файле к верхнему/нижнему регистру;  
- `* Вставить функцию переводчика. В качестве словарей можно использовать приложенные текстовые файлы, либо что-то своё. Переводчик должен переводить найденные слова. Если слово не найдено, он переходит к следующему.  
  
 (*) Все операции с чтением и записью производить через массивы байтов в явном виде, например:   
```
using (FileStream fs = new FileStream(fullPath, FileMode.OpenOrCreate))
{
    byte[] buffer = Encoding.Default.GetBytes(message);
    fs.Write(buffer,0,buffer.Length);
    
}
```
Если без `*, то можете делать это методами наподобие Write/ReadAllText, которые не требуют явного использования массива байт
