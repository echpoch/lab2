Что такое .NET Framework? Из чего он состоит?
.NET Framework — программная платформа, выпущенная компанией Microsoft в 2002 году. 
Основой платформы является общеязыковая среда исполнения Common Language Runtime (CLR),
которая подходит для разных языков программирования.
Функциональные возможности CLR доступны в любых языках программирования, использующих эту среду.


Сборка состоит из
Манифест, который содержит метаданные сборки

Метаданные типов. Используя эти метаданные, сборка определяет местоположение типов в файле приложения, а также места размещения их в памяти

Собственно код приложения на языке MSIL, в который компилируется код C#

Ресурсы


GAC = глобальный кэш сборок


FCL/BCL = библиотека классов платформы