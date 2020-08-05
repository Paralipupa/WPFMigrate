using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrateBase.Model
{
    class SQLTemplates
    {


        public string Create_Акт()
        {
            string nameTable = "Акт";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодПродажа` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Продажа` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПродажа` INT  NULL DEFAULT NULL";
            sql += ",`Номер` VARCHAR(30) NULL DEFAULT NULL";
            sql += ",`Дата` DATETIME NULL DEFAULT NULL";
            sql += ",`Сумма` FLOAT NULL DEFAULT NULL";
            sql += ",`Учтена` BIT NULL DEFAULT NULL";
            sql += ",`Дата выдачи` DATETIME NULL DEFAULT NULL";
            sql += ",`Получатель` VARCHAR(100) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_АктПозиция()
        {
            string nameTable = "АктПозиция";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодАкт` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Акт` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМАкт` INT  NULL DEFAULT NULL";
            sql += ",`КодПозиция` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Позиция` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПозиция` INT  NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_АктСтрока()
        {
            string nameTable = "АктСтрока";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодАкт` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Акт` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМАкт` INT  NULL DEFAULT NULL";
            sql += ",`КодСтрока` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Строка` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМСтрока` INT  NULL DEFAULT NULL";
            sql += ",`Порядок` INT NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Баланс()
        {
            string nameTable = "Баланс";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодКлиент` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Клиент` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМКлиент` INT  NULL DEFAULT NULL";
            sql += ",`КодДоговор` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Договор` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМДоговор` INT  NULL DEFAULT NULL";
            sql += ",`Сумма` FLOAT NULL DEFAULT NULL";
            sql += ",`Дата` DATETIME NULL DEFAULT NULL";
            sql += ",`КодПриходник` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Приходник` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПриходник` INT  NULL DEFAULT NULL";
            sql += ",`Активный` BIT NULL DEFAULT NULL";
            sql += ",`КодПримечания` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Примечания` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПримечания` INT  NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Банк()
        {
            string nameTable = "Банк";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`БИК` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Коррсчет` VARCHAR(150) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Город()
        {
            string nameTable = "Город";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодРегион` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Регион` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМРегион` INT  NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Декларант()
        {
            string nameTable = "Декларант";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Фамилия` VARCHAR(50) NULL DEFAULT NULL";
            sql += ",`Имя` VARCHAR(50) NULL DEFAULT NULL";
            sql += ",`Отчество` VARCHAR(50) NULL DEFAULT NULL";
            sql += ",`СНИЛС` VARCHAR(14) NULL DEFAULT NULL";
            sql += ",`Наименование документа` VARCHAR(100) NULL DEFAULT NULL";
            sql += ",`Серия` VARCHAR(5) NULL DEFAULT NULL";
            sql += ",`Номер` VARCHAR(6) NULL DEFAULT NULL";
            sql += ",`Дата выдачи` DATETIME NULL DEFAULT NULL";
            sql += ",`Кем выдан` VARCHAR(250) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Диадок()
        {
            string nameTable = "Диадок";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодКлиент` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Клиент` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМКлиент` INT  NULL DEFAULT NULL";
            sql += ",`Идентификатор` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Дата начала` DATETIME NULL DEFAULT NULL";
            sql += ",`Дата окончания` DATETIME NULL DEFAULT NULL";
            sql += ",`ID организации` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`ID ящика` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Проверка` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Дата занесения` DATETIME NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Дилер()
        {
            string nameTable = "Дилер";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодКлиент` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Клиент` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМКлиент` INT  NULL DEFAULT NULL";
            sql += ",`КодПримечания` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Примечания` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПримечания` INT  NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Договор()
        {
            string nameTable = "Договор";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Номер` VARCHAR(50) NULL DEFAULT NULL";
            sql += ",`Дата` DATETIME NULL DEFAULT NULL";
            sql += ",`Дата начала` DATETIME NULL DEFAULT NULL";
            sql += ",`Дата окончания` DATETIME NULL DEFAULT NULL";
            sql += ",`КодРаздел` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Раздел` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМРаздел` INT  NULL DEFAULT NULL";
            sql += ",`КодТипДоговора` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2ТипДоговора` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМТипДоговора` INT  NULL DEFAULT NULL";
            sql += ",`КодКлиент` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Клиент` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМКлиент` INT  NULL DEFAULT NULL";
            sql += ",`КодТипОтправкиДокумента` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2ТипОтправкиДокумента` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМТипОтправкиДокумента` INT  NULL DEFAULT NULL";
            sql += ",`КодПлательщик` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Плательщик` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПлательщик` INT  NULL DEFAULT NULL";
            sql += ",`КодПримечания` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Примечания` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПримечания` INT  NULL DEFAULT NULL";
            sql += ",`Активный` BIT NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_ДоговорПрайслист()
        {
            string nameTable = "ДоговорПрайслист";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодДоговор` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Договор` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМДоговор` INT  NULL DEFAULT NULL";
            sql += ",`Дата начала` DATETIME NULL DEFAULT NULL";
            sql += ",`Дата окончания` DATETIME NULL DEFAULT NULL";
            sql += ",`КодПрайслист` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Прайслист` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПрайслист` INT  NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_ДоговорСкидка()
        {
            string nameTable = "ДоговорСкидка";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодДоговор` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Договор` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМДоговор` INT  NULL DEFAULT NULL";
            sql += ",`КодСкидка` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Скидка` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМСкидка` INT  NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Должность()
        {
            string nameTable = "Должность";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Дата начала` DATETIME NULL DEFAULT NULL";
            sql += ",`Дата окончания` DATETIME NULL DEFAULT NULL";
            sql += ",`КодПримечания` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Примечания` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПримечания` INT  NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Журналработы()
        {
            string nameTable = "Журнал работы";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодКлиент` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Клиент` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМКлиент` INT  NULL DEFAULT NULL";
            sql += ",`КодПользователь` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Пользователь` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПользователь` INT  NULL DEFAULT NULL";
            sql += ",`КодПримечания` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Примечания` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПримечания` INT  NULL DEFAULT NULL";
            sql += ",`Дата` DATETIME NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Журналсообщений()
        {
            string nameTable = "Журнал сообщений";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Дата` DATETIME NULL DEFAULT NULL";
            sql += ",`КодКлиент` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Клиент` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМКлиент` INT  NULL DEFAULT NULL";
            sql += ",`ЭлПочта` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодПримечания` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Примечания` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПримечания` INT  NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Журналстатистики()
        {
            string nameTable = "Журнал статистики";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Дата начала` DATETIME NULL DEFAULT NULL";
            sql += ",`Дата окончания` DATETIME NULL DEFAULT NULL";
            sql += ",`КодПримечания` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Примечания` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПримечания` INT  NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Заявка()
        {
            string nameTable = "Заявка";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодТипЗаявки` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2ТипЗаявки` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМТипЗаявки` INT  NULL DEFAULT NULL";
            sql += ",`Номер` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Дата` DATETIME NULL DEFAULT NULL";
            sql += ",`КодПоставщик` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Поставщик` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПоставщик` INT  NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_ЗаявкаЭП()
        {
            string nameTable = "ЗаявкаЭП";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодЗаявка` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Заявка` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМЗаявка` INT  NULL DEFAULT NULL";
            sql += ",`КодЭП` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2ЭП` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМЭП` INT  NULL DEFAULT NULL";
            sql += ",`Дата занесения` DATETIME NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Категория()
        {
            string nameTable = "Категория";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Клиент()
        {
            string nameTable = "Клиент";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Краткое наименование` VARCHAR(50) NULL DEFAULT NULL";
            sql += ",`КодОПФ` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2ОПФ` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМОПФ` INT  NULL DEFAULT NULL";
            sql += ",`ИНН` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КПП` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`ОГРН` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодГород` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Город` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМГород` INT  NULL DEFAULT NULL";
            sql += ",`КодПримечания` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Примечания` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПримечания` INT  NULL DEFAULT NULL";
            sql += ",`КодПризнакКлиента` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2ПризнакКлиента` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПризнакКлиента` INT  NULL DEFAULT NULL";
            sql += ",`$Город` VARCHAR(150) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Журналзадолженности()
        {
            string nameTable = "Журнал задолженности";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Дата` DATETIME NULL DEFAULT NULL";
            sql += ",`КодКлиент` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Клиент` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМКлиент` INT  NULL DEFAULT NULL";
            sql += ",`КодДоговор` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Договор` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМДоговор` INT  NULL DEFAULT NULL";
            sql += ",`Активный` BIT NULL DEFAULT NULL";
            sql += ",`КодПримечания` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Примечания` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПримечания` INT  NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_ПакетНоменклатура()
        {
            string nameTable = "ПакетНоменклатура";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодПакет` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Пакет` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПакет` INT  NULL DEFAULT NULL";
            sql += ",`КодНоменклатура` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Номенклатура` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМНоменклатура` INT  NULL DEFAULT NULL";
            sql += ",`Количество` INT NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Номенклатура()
        {
            string nameTable = "Номенклатура";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Краткое наименование` VARCHAR(50) NULL DEFAULT NULL";
            sql += ",`КодТипЕдиницы` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2ТипЕдиницы` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМТипЕдиницы` INT  NULL DEFAULT NULL";
            sql += ",`Описание` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Порядок` INT NULL DEFAULT NULL";
            sql += ",`КодКатегория` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Категория` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМКатегория` INT  NULL DEFAULT NULL";
            sql += ",`КодПримечания` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Примечания` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПримечания` INT  NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_ОПФ()
        {
            string nameTable = "ОПФ";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Краткое наименование` VARCHAR(50) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Пакет()
        {
            string nameTable = "Пакет";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодНоменклатура` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Номенклатура` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМНоменклатура` INT  NULL DEFAULT NULL";
            sql += ",`Количество` INT NULL DEFAULT NULL";
            sql += ",`КодЦена` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Цена` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМЦена` INT  NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_ПакетДоговор()
        {
            string nameTable = "ПакетДоговор";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодПакет` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Пакет` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПакет` INT  NULL DEFAULT NULL";
            sql += ",`КодДоговор` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Договор` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМДоговор` INT  NULL DEFAULT NULL";
            sql += ",`КодКлиент` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Клиент` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМКлиент` INT  NULL DEFAULT NULL";
            sql += ",`Дата начала` DATETIME NULL DEFAULT NULL";
            sql += ",`Дата окончания` DATETIME NULL DEFAULT NULL";
            sql += ",`Количество` INT NULL DEFAULT NULL";
            sql += ",`Остаток` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодПримечания` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Примечания` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПримечания` INT  NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_ПакетДоговорЖурнал()
        {
            string nameTable = "ПакетДоговорЖурнал";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодПакетДоговор` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2ПакетДоговор` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПакетДоговор` INT  NULL DEFAULT NULL";
            sql += ",`Количество` INT NULL DEFAULT NULL";
            sql += ",`Дата` DATETIME NULL DEFAULT NULL";
            sql += ",`КодТипСобытияПакета` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2ТипСобытияПакета` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМТипСобытияПакета` INT  NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_ПакетДоговорОбслуживание()
        {
            string nameTable = "ПакетДоговорОбслуживание";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодКлиент` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Клиент` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМКлиент` INT  NULL DEFAULT NULL";
            sql += ",`КодПакетДоговор` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2ПакетДоговор` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПакетДоговор` INT  NULL DEFAULT NULL";
            sql += ",`КодПериод` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Период` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПериод` INT  NULL DEFAULT NULL";
            sql += ",`КодНоменклатура` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Номенклатура` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМНоменклатура` INT  NULL DEFAULT NULL";
            sql += ",`Количество` INT NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_ПакетДоговорСкидка()
        {
            string nameTable = "ПакетДоговорСкидка";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодПакет` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Пакет` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПакет` INT  NULL DEFAULT NULL";
            sql += ",`КодСкидка` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Скидка` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМСкидка` INT  NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Период()
        {
            string nameTable = "Период";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Дата начала` DATETIME NULL DEFAULT NULL";
            sql += ",`Дата окончания` DATETIME NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Персонал()
        {
            string nameTable = "Персонал";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодПоставщик` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Поставщик` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПоставщик` INT  NULL DEFAULT NULL";
            sql += ",`КодДолжность` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Должность` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМДолжность` INT  NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Плательщик()
        {
            string nameTable = "Плательщик";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодКлиент` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Клиент` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМКлиент` INT  NULL DEFAULT NULL";
            sql += ",`КодПримечания` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Примечания` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПримечания` INT  NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Позиция()
        {
            string nameTable = "Позиция";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодПродажа` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Продажа` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПродажа` INT  NULL DEFAULT NULL";
            sql += ",`КодПродукт` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Продукт` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПродукт` INT  NULL DEFAULT NULL";
            sql += ",`КодПериод` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Период` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПериод` INT  NULL DEFAULT NULL";
            sql += ",`Количество` INT NULL DEFAULT NULL";
            sql += ",`Цена` FLOAT NULL DEFAULT NULL";
            sql += ",`Сумма` FLOAT NULL DEFAULT NULL";
            sql += ",`СуммаСкидки` FLOAT NULL DEFAULT NULL";
            sql += ",`Итого` FLOAT NULL DEFAULT NULL";
            sql += ",`Оплачено` BIT NULL DEFAULT NULL";
            sql += ",`ДатаСоздания` DATETIME NULL DEFAULT NULL";
            sql += ",`$КодПозицияОсновная` VARCHAR(150) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_ПозицияСкидка()
        {
            string nameTable = "ПозицияСкидка";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодПозиция` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Позиция` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПозиция` INT  NULL DEFAULT NULL";
            sql += ",`КодСкидка` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Скидка` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМСкидка` INT  NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Пользователь()
        {
            string nameTable = "Пользователь";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодРоль` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Роль` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМРоль` INT  NULL DEFAULT NULL";
            sql += ",`КодПримечания` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Примечания` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПримечания` INT  NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Поставщик()
        {
            string nameTable = "Поставщик";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодКлиент` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Клиент` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМКлиент` INT  NULL DEFAULT NULL";
            sql += ",`КодПримечания` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Примечания` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПримечания` INT  NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Прайслист()
        {
            string nameTable = "Прайслист";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Дата начала` DATETIME NULL DEFAULT NULL";
            sql += ",`Дата окончания` DATETIME NULL DEFAULT NULL";
            sql += ",`Порядок` INT NULL DEFAULT NULL";
            sql += ",`Описание` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Активный` BIT NULL DEFAULT NULL";
            sql += ",`КодРаздел` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Раздел` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМРаздел` INT  NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Плательщик_Клиент()
        {
            string nameTable = "Плательщик-Клиент";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодПлательщик` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Плательщик` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПлательщик` INT  NULL DEFAULT NULL";
            sql += ",`КодКлиент` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Клиент` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМКлиент` INT  NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Группа()
        {
            string nameTable = "Группа";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_ГруппаПродукт()
        {
            string nameTable = "ГруппаПродукт";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодГруппа` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Группа` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМГруппа` INT  NULL DEFAULT NULL";
            sql += ",`КодПродукт` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Продукт` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПродукт` INT  NULL DEFAULT NULL";
            sql += ",`Уникальный` VARCHAR(150) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Продукт()
        {
            string nameTable = "Продукт";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодПрайслист` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Прайслист` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПрайслист` INT  NULL DEFAULT NULL";
            sql += ",`КодНоменклатура` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Номенклатура` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМНоменклатура` INT  NULL DEFAULT NULL";
            sql += ",`Уникальный` VARCHAR(150) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Признакклиента()
        {
            string nameTable = "Признак клиента";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Примечания()
        {
            string nameTable = "Примечания";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодТаблицы` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Таблицы` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМТаблицы` INT  NULL DEFAULT NULL";
            sql += ",`Счетчик` INT NULL DEFAULT NULL";
            sql += ",`Содержание` MEDIUMTEXT NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Продажа()
        {
            string nameTable = "Продажа";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Дата создания` DATETIME NULL DEFAULT NULL";
            sql += ",`Дата расчета` DATETIME NULL DEFAULT NULL";
            sql += ",`Оплачено` BIT NULL DEFAULT NULL";
            sql += ",`КодКлиент` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Клиент` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМКлиент` INT  NULL DEFAULT NULL";
            sql += ",`КодДоговор` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Договор` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМДоговор` INT  NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Раздел()
        {
            string nameTable = "Раздел";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Описание` VARCHAR(150) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Регион()
        {
            string nameTable = "Регион";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Номер региона` VARCHAR(4) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Приходник()
        {
            string nameTable = "Приходник";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодТипПРО` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2ТипПРО` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМТипПРО` INT  NULL DEFAULT NULL";
            sql += ",`Номер` VARCHAR(30) NULL DEFAULT NULL";
            sql += ",`Дата` DATETIME NULL DEFAULT NULL";
            sql += ",`Сумма` FLOAT NULL DEFAULT NULL";
            sql += ",`КодКлиент` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Клиент` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМКлиент` INT  NULL DEFAULT NULL";
            sql += ",`Учтена` BIT NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_ПриходникДоговор()
        {
            string nameTable = "ПриходникДоговор";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодПриходник` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Приходник` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПриходник` INT  NULL DEFAULT NULL";
            sql += ",`КодДоговор` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Договор` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМДоговор` INT  NULL DEFAULT NULL";
            sql += ",`Сумма` FLOAT NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Реквизит()
        {
            string nameTable = "Реквизит";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодТипРеквизита` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2ТипРеквизита` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМТипРеквизита` INT  NULL DEFAULT NULL";
            sql += ",`Значение` VARCHAR(250) NULL DEFAULT NULL";
            sql += ",`Активный` BIT NULL DEFAULT NULL";
            sql += ",`КодКлиент` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Клиент` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМКлиент` INT  NULL DEFAULT NULL";
            sql += ",`КодПримечания` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Примечания` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПримечания` INT  NULL DEFAULT NULL";
            sql += ",`Учтена` BIT NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Роль()
        {
            string nameTable = "Роль";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодПримечания` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Примечания` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПримечания` INT  NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Скидка()
        {
            string nameTable = "Скидка";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодТипСкидки` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2ТипСкидки` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМТипСкидки` INT  NULL DEFAULT NULL";
            sql += ",`Размер` FLOAT NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Строка()
        {
            string nameTable = "Строка";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодПозиция` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Позиция` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПозиция` INT  NULL DEFAULT NULL";
            sql += ",`Количество` INT NULL DEFAULT NULL";
            sql += ",`КодТипЕдиницы` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2ТипЕдиницы` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМТипЕдиницы` INT  NULL DEFAULT NULL";
            sql += ",`Цена` FLOAT NULL DEFAULT NULL";
            sql += ",`Сумма` FLOAT NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Счет()
        {
            string nameTable = "Счет";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодПродажа` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Продажа` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПродажа` INT  NULL DEFAULT NULL";
            sql += ",`Номер` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Дата` DATETIME NULL DEFAULT NULL";
            sql += ",`Сумма` FLOAT NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_СчетПозиция()
        {
            string nameTable = "СчетПозиция";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодСчет` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Счет` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМСчет` INT  NULL DEFAULT NULL";
            sql += ",`КодПозиция` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Позиция` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПозиция` INT  NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_СчетСтрока()
        {
            string nameTable = "СчетСтрока";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодСчет` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Счет` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМСчет` INT  NULL DEFAULT NULL";
            sql += ",`КодСтрока` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Строка` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМСтрока` INT  NULL DEFAULT NULL";
            sql += ",`Порядок` INT NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Таблицы()
        {
            string nameTable = "Таблицы";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Описание` VARCHAR(100) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Типверсиипрограммы()
        {
            string nameTable = "Тип версии программы";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Типдоговора()
        {
            string nameTable = "Тип договора";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`НаименованиеПредложное` VARCHAR(50) NULL DEFAULT NULL";
            sql += ",`НаименованиеРодительское` VARCHAR(50) NULL DEFAULT NULL";
            sql += ",`Описание` VARCHAR(100) NULL DEFAULT NULL";
            sql += ",`ФайлШаблона` VARCHAR(100) NULL DEFAULT NULL";
            sql += ",`Префикс` VARCHAR(20) NULL DEFAULT NULL";
            sql += ",`КодПоставщик` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Поставщик` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПоставщик` INT  NULL DEFAULT NULL";
            sql += ",`КодДилер` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Дилер` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМДилер` INT  NULL DEFAULT NULL";
            sql += ",`Порядковый номер` VARCHAR(150) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Типединицы()
        {
            string nameTable = "Тип единицы";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КраткоеНаименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Штучный` BIT NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Типзаявки()
        {
            string nameTable = "Тип заявки";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Типотправкидокумента()
        {
            string nameTable = "Тип отправки документа";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_ТипПРО()
        {
            string nameTable = "Тип ПРО";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Типреквизита()
        {
            string nameTable = "Тип реквизита";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Порядок` INT NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Типскидки()
        {
            string nameTable = "Тип скидки";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Типсобытияпакета()
        {
            string nameTable = "Тип события пакета";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_ТипстатусаАО()
        {
            string nameTable = "Тип статуса АО";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Типцены()
        {
            string nameTable = "Тип цены";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_ТипЭД2()
        {
            string nameTable = "Тип ЭД2";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_ТоварАО()
        {
            string nameTable = "ТоварАО";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодКлиент` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Клиент` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМКлиент` INT  NULL DEFAULT NULL";
            sql += ",`КодДоговор` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Договор` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМДоговор` INT  NULL DEFAULT NULL";
            sql += ",`КодНоменклатура` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Номенклатура` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМНоменклатура` INT  NULL DEFAULT NULL";
            sql += ",`Копия` INT NULL DEFAULT NULL";
            sql += ",`КодЦена` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Цена` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМЦена` INT  NULL DEFAULT NULL";
            sql += ",`Сумма` FLOAT NULL DEFAULT NULL";
            sql += ",`Дата создания` DATETIME NULL DEFAULT NULL";
            sql += ",`Пересчитано` BIT NULL DEFAULT NULL";
            sql += ",`КодПримечания` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Примечания` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПримечания` INT  NULL DEFAULT NULL";
            sql += ",`КодПозиция` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Позиция` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПозиция` INT  NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_ТоварАОПериод()
        {
            string nameTable = "ТоварАОПериод";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодТоварАО` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2ТоварАО` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМТоварАО` INT  NULL DEFAULT NULL";
            sql += ",`КодПозиция` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Позиция` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПозиция` INT  NULL DEFAULT NULL";
            sql += ",`КодПериод` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Период` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПериод` INT  NULL DEFAULT NULL";
            sql += ",`Количество` INT NULL DEFAULT NULL";
            sql += ",`Сумма` FLOAT NULL DEFAULT NULL";
            sql += ",`Оплачено` BIT NULL DEFAULT NULL";
            sql += ",`Дата создания` DATETIME NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_ТоварАОСтатус()
        {
            string nameTable = "ТоварАОСтатус";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодТоварАО` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2ТоварАО` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМТоварАО` INT  NULL DEFAULT NULL";
            sql += ",`КодТипСтатусаАО` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2ТипСтатусаАО` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМТипСтатусаАО` INT  NULL DEFAULT NULL";
            sql += ",`Дата` DATETIME NULL DEFAULT NULL";
            sql += ",`Активная` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодПримечания` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Примечания` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПримечания` INT  NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_УчетныеданныеЭД2()
        {
            string nameTable = "Учетные данные ЭД2";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодТипЭД2` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2ТипЭД2` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМТипЭД2` INT  NULL DEFAULT NULL";
            sql += ",`Дата` DATETIME NULL DEFAULT NULL";
            sql += ",`КодКлиент` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Клиент` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМКлиент` INT  NULL DEFAULT NULL";
            sql += ",`КодДоговор` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Договор` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМДоговор` INT  NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Цена()
        {
            string nameTable = "Цена";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодТипЦены` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2ТипЦены` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМТипЦены` INT  NULL DEFAULT NULL";
            sql += ",`Количество` INT NULL DEFAULT NULL";
            sql += ",`Копия` INT NULL DEFAULT NULL";
            sql += ",`Сумма` FLOAT NULL DEFAULT NULL";
            sql += ",`КодСкидка` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Скидка` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМСкидка` INT  NULL DEFAULT NULL";
            sql += ",`КодПродукт` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Продукт` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПродукт` INT  NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_ЭП()
        {
            string nameTable = "ЭП";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`_КодЭД2`INT NULL  DEFAULT NULL";
            sql += ",`_КодСТМ`INT NULL  DEFAULT NULL";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодКлиент` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Клиент` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМКлиент` INT  NULL DEFAULT NULL";
            sql += ",`КодДоговор` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Договор` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМДоговор` INT  NULL DEFAULT NULL";
            sql += ",`КодДекларант` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Декларант` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМДекларант` INT  NULL DEFAULT NULL";
            sql += ",`Номер` VARCHAR(30) NULL DEFAULT NULL";
            sql += ",`Дата` DATETIME NULL DEFAULT NULL";
            sql += ",`Дата занесения` DATETIME NULL DEFAULT NULL";
            sql += ",`Дата Получения` DATETIME NULL DEFAULT NULL";
            sql += ",`КодПримечания` INT NULL DEFAULT NULL";
            sql += ",`_КодЭД2Примечания` INT  NULL DEFAULT NULL";
            sql += ",`_КодСТМПримечания` INT  NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }
        public string RelationIndex_Продажа_Акт()
        {
            string sql = "ALTER TABLE `Акт` ADD INDEX (`КодПродажа`)";
            return sql;
        }
        public string Relation_Продажа_Акт()
        {
            string sql = "ALTER TABLE `Акт` ADD FOREIGN KEY (`КодПродажа`) REFERENCES `Продажа`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Акт_АктПозиция()
        {
            string sql = "ALTER TABLE `АктПозиция` ADD INDEX (`КодАкт`)";
            return sql;
        }
        public string Relation_Акт_АктПозиция()
        {
            string sql = "ALTER TABLE `АктПозиция` ADD FOREIGN KEY (`КодАкт`) REFERENCES `Акт`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Позиция_АктПозиция()
        {
            string sql = "ALTER TABLE `АктПозиция` ADD INDEX (`КодПозиция`)";
            return sql;
        }
        public string Relation_Позиция_АктПозиция()
        {
            string sql = "ALTER TABLE `АктПозиция` ADD FOREIGN KEY (`КодПозиция`) REFERENCES `Позиция`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Акт_АктСтрока()
        {
            string sql = "ALTER TABLE `АктСтрока` ADD INDEX (`КодАкт`)";
            return sql;
        }
        public string Relation_Акт_АктСтрока()
        {
            string sql = "ALTER TABLE `АктСтрока` ADD FOREIGN KEY (`КодАкт`) REFERENCES `Акт`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Строка_АктСтрока()
        {
            string sql = "ALTER TABLE `АктСтрока` ADD INDEX (`КодСтрока`)";
            return sql;
        }
        public string Relation_Строка_АктСтрока()
        {
            string sql = "ALTER TABLE `АктСтрока` ADD FOREIGN KEY (`КодСтрока`) REFERENCES `Строка`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Клиент_Баланс()
        {
            string sql = "ALTER TABLE `Баланс` ADD INDEX (`КодКлиент`)";
            return sql;
        }
        public string Relation_Клиент_Баланс()
        {
            string sql = "ALTER TABLE `Баланс` ADD FOREIGN KEY (`КодКлиент`) REFERENCES `Клиент`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Договор_Баланс()
        {
            string sql = "ALTER TABLE `Баланс` ADD INDEX (`КодДоговор`)";
            return sql;
        }
        public string Relation_Договор_Баланс()
        {
            string sql = "ALTER TABLE `Баланс` ADD FOREIGN KEY (`КодДоговор`) REFERENCES `Договор`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Приходник_Баланс()
        {
            string sql = "ALTER TABLE `Баланс` ADD INDEX (`КодПриходник`)";
            return sql;
        }
        public string Relation_Приходник_Баланс()
        {
            string sql = "ALTER TABLE `Баланс` ADD FOREIGN KEY (`КодПриходник`) REFERENCES `Приходник`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Примечания_Баланс()
        {
            string sql = "ALTER TABLE `Баланс` ADD INDEX (`КодПримечания`)";
            return sql;
        }
        public string Relation_Примечания_Баланс()
        {
            string sql = "ALTER TABLE `Баланс` ADD FOREIGN KEY (`КодПримечания`) REFERENCES `Примечания`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Регион_Город()
        {
            string sql = "ALTER TABLE `Город` ADD INDEX (`КодРегион`)";
            return sql;
        }
        public string Relation_Регион_Город()
        {
            string sql = "ALTER TABLE `Город` ADD FOREIGN KEY (`КодРегион`) REFERENCES `Регион`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Группа_ГруппаПродукт()
        {
            string sql = "ALTER TABLE `ГруппаПродукт` ADD INDEX (`КодГруппа`)";
            return sql;
        }
        public string Relation_Группа_ГруппаПродукт()
        {
            string sql = "ALTER TABLE `ГруппаПродукт` ADD FOREIGN KEY (`КодГруппа`) REFERENCES `Группа`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Продукт_ГруппаПродукт()
        {
            string sql = "ALTER TABLE `ГруппаПродукт` ADD INDEX (`КодПродукт`)";
            return sql;
        }
        public string Relation_Продукт_ГруппаПродукт()
        {
            string sql = "ALTER TABLE `ГруппаПродукт` ADD FOREIGN KEY (`КодПродукт`) REFERENCES `Продукт`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Клиент_Диадок()
        {
            string sql = "ALTER TABLE `Диадок` ADD INDEX (`КодКлиент`)";
            return sql;
        }
        public string Relation_Клиент_Диадок()
        {
            string sql = "ALTER TABLE `Диадок` ADD FOREIGN KEY (`КодКлиент`) REFERENCES `Клиент`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Клиент_Дилер()
        {
            string sql = "ALTER TABLE `Дилер` ADD INDEX (`КодКлиент`)";
            return sql;
        }
        public string Relation_Клиент_Дилер()
        {
            string sql = "ALTER TABLE `Дилер` ADD FOREIGN KEY (`КодКлиент`) REFERENCES `Клиент`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Примечания_Дилер()
        {
            string sql = "ALTER TABLE `Дилер` ADD INDEX (`КодПримечания`)";
            return sql;
        }
        public string Relation_Примечания_Дилер()
        {
            string sql = "ALTER TABLE `Дилер` ADD FOREIGN KEY (`КодПримечания`) REFERENCES `Примечания`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Раздел_Договор()
        {
            string sql = "ALTER TABLE `Договор` ADD INDEX (`КодРаздел`)";
            return sql;
        }
        public string Relation_Раздел_Договор()
        {
            string sql = "ALTER TABLE `Договор` ADD FOREIGN KEY (`КодРаздел`) REFERENCES `Раздел`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Типдоговора_Договор()
        {
            string sql = "ALTER TABLE `Договор` ADD INDEX (`КодТипдоговора`)";
            return sql;
        }
        public string Relation_Типдоговора_Договор()
        {
            string sql = "ALTER TABLE `Договор` ADD FOREIGN KEY (`КодТипдоговора`) REFERENCES `Тип договора `(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Клиент_Договор()
        {
            string sql = "ALTER TABLE `Договор` ADD INDEX (`КодКлиент`)";
            return sql;
        }
        public string Relation_Клиент_Договор()
        {
            string sql = "ALTER TABLE `Договор` ADD FOREIGN KEY (`КодКлиент`) REFERENCES `Клиент`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Типотправкидокумента_Договор()
        {
            string sql = "ALTER TABLE `Договор` ADD INDEX (`КодТипотправкидокумента`)";
            return sql;
        }
        public string Relation_Типотправкидокумента_Договор()
        {
            string sql = "ALTER TABLE `Договор` ADD FOREIGN KEY (`КодТипотправкидокумента`) REFERENCES `Тип отправки документа`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Плательщик_Договор()
        {
            string sql = "ALTER TABLE `Договор` ADD INDEX (`КодПлательщик`)";
            return sql;
        }
        public string Relation_Плательщик_Договор()
        {
            string sql = "ALTER TABLE `Договор` ADD FOREIGN KEY (`КодПлательщик`) REFERENCES `Плательщик`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Примечания_Договор()
        {
            string sql = "ALTER TABLE `Договор` ADD INDEX (`КодПримечания`)";
            return sql;
        }
        public string Relation_Примечания_Договор()
        {
            string sql = "ALTER TABLE `Договор` ADD FOREIGN KEY (`КодПримечания`) REFERENCES `Примечания`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Договор_ДоговорПрайслист()
        {
            string sql = "ALTER TABLE `ДоговорПрайслист` ADD INDEX (`КодДоговор`)";
            return sql;
        }
        public string Relation_Договор_ДоговорПрайслист()
        {
            string sql = "ALTER TABLE `ДоговорПрайслист` ADD FOREIGN KEY (`КодДоговор`) REFERENCES `Договор`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Прайслист_ДоговорПрайслист()
        {
            string sql = "ALTER TABLE `ДоговорПрайслист` ADD INDEX (`КодПрайслист`)";
            return sql;
        }
        public string Relation_Прайслист_ДоговорПрайслист()
        {
            string sql = "ALTER TABLE `ДоговорПрайслист` ADD FOREIGN KEY (`КодПрайслист`) REFERENCES `Прайслист`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Договор_ДоговорСкидка()
        {
            string sql = "ALTER TABLE `ДоговорСкидка` ADD INDEX (`КодДоговор`)";
            return sql;
        }
        public string Relation_Договор_ДоговорСкидка()
        {
            string sql = "ALTER TABLE `ДоговорСкидка` ADD FOREIGN KEY (`КодДоговор`) REFERENCES `Договор`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Скидка_ДоговорСкидка()
        {
            string sql = "ALTER TABLE `ДоговорСкидка` ADD INDEX (`КодСкидка`)";
            return sql;
        }
        public string Relation_Скидка_ДоговорСкидка()
        {
            string sql = "ALTER TABLE `ДоговорСкидка` ADD FOREIGN KEY (`КодСкидка`) REFERENCES `Скидка`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Примечания_Должность()
        {
            string sql = "ALTER TABLE `Должность` ADD INDEX (`КодПримечания`)";
            return sql;
        }
        public string Relation_Примечания_Должность()
        {
            string sql = "ALTER TABLE `Должность` ADD FOREIGN KEY (`КодПримечания`) REFERENCES `Примечания`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Клиент_Журналзадолженности()
        {
            string sql = "ALTER TABLE `Журнал задолженности` ADD INDEX (`КодКлиент`)";
            return sql;
        }
        public string Relation_Клиент_Журналзадолженности()
        {
            string sql = "ALTER TABLE `Журнал задолженности` ADD FOREIGN KEY (`КодКлиент`) REFERENCES `Клиент`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Договор_Журналзадолженности()
        {
            string sql = "ALTER TABLE `Журнал задолженности` ADD INDEX (`КодДоговор`)";
            return sql;
        }
        public string Relation_Договор_Журналзадолженности()
        {
            string sql = "ALTER TABLE `Журнал задолженности` ADD FOREIGN KEY (`КодДоговор`) REFERENCES `Договор`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Примечания_Журналзадолженности()
        {
            string sql = "ALTER TABLE `Журнал задолженности` ADD INDEX (`КодПримечания`)";
            return sql;
        }
        public string Relation_Примечания_Журналзадолженности()
        {
            string sql = "ALTER TABLE `Журнал задолженности` ADD FOREIGN KEY (`КодПримечания`) REFERENCES `Примечания`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Клиент_Журналработы()
        {
            string sql = "ALTER TABLE `Журнал работы` ADD INDEX (`КодКлиент`)";
            return sql;
        }
        public string Relation_Клиент_Журналработы()
        {
            string sql = "ALTER TABLE `Журнал работы` ADD FOREIGN KEY (`КодКлиент`) REFERENCES `Клиент`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Пользователь_Журналработы()
        {
            string sql = "ALTER TABLE `Журнал работы` ADD INDEX (`КодПользователь`)";
            return sql;
        }
        public string Relation_Пользователь_Журналработы()
        {
            string sql = "ALTER TABLE `Журнал работы` ADD FOREIGN KEY (`КодПользователь`) REFERENCES `Пользователь`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Примечания_Журналработы()
        {
            string sql = "ALTER TABLE `Журнал работы` ADD INDEX (`КодПримечания`)";
            return sql;
        }
        public string Relation_Примечания_Журналработы()
        {
            string sql = "ALTER TABLE `Журнал работы` ADD FOREIGN KEY (`КодПримечания`) REFERENCES `Примечания`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Клиент_Журналсообщений()
        {
            string sql = "ALTER TABLE `Журнал сообщений` ADD INDEX (`КодКлиент`)";
            return sql;
        }
        public string Relation_Клиент_Журналсообщений()
        {
            string sql = "ALTER TABLE `Журнал сообщений` ADD FOREIGN KEY (`КодКлиент`) REFERENCES `Клиент`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Примечания_Журналсообщений()
        {
            string sql = "ALTER TABLE `Журнал сообщений` ADD INDEX (`КодПримечания`)";
            return sql;
        }
        public string Relation_Примечания_Журналсообщений()
        {
            string sql = "ALTER TABLE `Журнал сообщений` ADD FOREIGN KEY (`КодПримечания`) REFERENCES `Примечания`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Примечания_Журналстатистики()
        {
            string sql = "ALTER TABLE `Журнал статистики` ADD INDEX (`КодПримечания`)";
            return sql;
        }
        public string Relation_Примечания_Журналстатистики()
        {
            string sql = "ALTER TABLE `Журнал статистики` ADD FOREIGN KEY (`КодПримечания`) REFERENCES `Примечания`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Типзаявки_Заявка()
        {
            string sql = "ALTER TABLE `Заявка` ADD INDEX (`КодТипзаявки`)";
            return sql;
        }
        public string Relation_Типзаявки_Заявка()
        {
            string sql = "ALTER TABLE `Заявка` ADD FOREIGN KEY (`КодТипзаявки`) REFERENCES `Тип заявки`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Поставщик_Заявка()
        {
            string sql = "ALTER TABLE `Заявка` ADD INDEX (`КодПоставщик`)";
            return sql;
        }
        public string Relation_Поставщик_Заявка()
        {
            string sql = "ALTER TABLE `Заявка` ADD FOREIGN KEY (`КодПоставщик`) REFERENCES `Поставщик`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Заявка_ЗаявкаЭП()
        {
            string sql = "ALTER TABLE `ЗаявкаЭП` ADD INDEX (`КодЗаявка`)";
            return sql;
        }
        public string Relation_Заявка_ЗаявкаЭП()
        {
            string sql = "ALTER TABLE `ЗаявкаЭП` ADD FOREIGN KEY (`КодЗаявка`) REFERENCES `Заявка`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_ЭП_ЗаявкаЭП()
        {
            string sql = "ALTER TABLE `ЗаявкаЭП` ADD INDEX (`КодЭП`)";
            return sql;
        }
        public string Relation_ЭП_ЗаявкаЭП()
        {
            string sql = "ALTER TABLE `ЗаявкаЭП` ADD FOREIGN KEY (`КодЭП`) REFERENCES `ЭП`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_ОПФ_Клиент()
        {
            string sql = "ALTER TABLE `Клиент` ADD INDEX (`КодОПФ`)";
            return sql;
        }
        public string Relation_ОПФ_Клиент()
        {
            string sql = "ALTER TABLE `Клиент` ADD FOREIGN KEY (`КодОПФ`) REFERENCES `ОПФ`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Город_Клиент()
        {
            string sql = "ALTER TABLE `Клиент` ADD INDEX (`КодГород`)";
            return sql;
        }
        public string Relation_Город_Клиент()
        {
            string sql = "ALTER TABLE `Клиент` ADD FOREIGN KEY (`КодГород`) REFERENCES `Город`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Примечания_Клиент()
        {
            string sql = "ALTER TABLE `Клиент` ADD INDEX (`КодПримечания`)";
            return sql;
        }
        public string Relation_Примечания_Клиент()
        {
            string sql = "ALTER TABLE `Клиент` ADD FOREIGN KEY (`КодПримечания`) REFERENCES `Примечания`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Признакклиента_Клиент()
        {
            string sql = "ALTER TABLE `Клиент` ADD INDEX (`КодПризнакклиента`)";
            return sql;
        }
        public string Relation_Признакклиента_Клиент()
        {
            string sql = "ALTER TABLE `Клиент` ADD FOREIGN KEY (`КодПризнакклиента`) REFERENCES `Признак клиента`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Типединицы_Номенклатура()
        {
            string sql = "ALTER TABLE `Номенклатура` ADD INDEX (`КодТипединицы`)";
            return sql;
        }
        public string Relation_Типединицы_Номенклатура()
        {
            string sql = "ALTER TABLE `Номенклатура` ADD FOREIGN KEY (`КодТипединицы`) REFERENCES `Тип единицы`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Категория_Номенклатура()
        {
            string sql = "ALTER TABLE `Номенклатура` ADD INDEX (`КодКатегория`)";
            return sql;
        }
        public string Relation_Категория_Номенклатура()
        {
            string sql = "ALTER TABLE `Номенклатура` ADD FOREIGN KEY (`КодКатегория`) REFERENCES `Категория`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Примечания_Номенклатура()
        {
            string sql = "ALTER TABLE `Номенклатура` ADD INDEX (`КодПримечания`)";
            return sql;
        }
        public string Relation_Примечания_Номенклатура()
        {
            string sql = "ALTER TABLE `Номенклатура` ADD FOREIGN KEY (`КодПримечания`) REFERENCES `Примечания`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Номенклатура_Пакет()
        {
            string sql = "ALTER TABLE `Пакет` ADD INDEX (`КодНоменклатура`)";
            return sql;
        }
        public string Relation_Номенклатура_Пакет()
        {
            string sql = "ALTER TABLE `Пакет` ADD FOREIGN KEY (`КодНоменклатура`) REFERENCES `Номенклатура`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Цена_Пакет()
        {
            string sql = "ALTER TABLE `Пакет` ADD INDEX (`КодЦена`)";
            return sql;
        }
        public string Relation_Цена_Пакет()
        {
            string sql = "ALTER TABLE `Пакет` ADD FOREIGN KEY (`КодЦена`) REFERENCES `Цена`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Пакет_ПакетДоговор()
        {
            string sql = "ALTER TABLE `ПакетДоговор` ADD INDEX (`КодПакет`)";
            return sql;
        }
        public string Relation_Пакет_ПакетДоговор()
        {
            string sql = "ALTER TABLE `ПакетДоговор` ADD FOREIGN KEY (`КодПакет`) REFERENCES `Пакет`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Договор_ПакетДоговор()
        {
            string sql = "ALTER TABLE `ПакетДоговор` ADD INDEX (`КодДоговор`)";
            return sql;
        }
        public string Relation_Договор_ПакетДоговор()
        {
            string sql = "ALTER TABLE `ПакетДоговор` ADD FOREIGN KEY (`КодДоговор`) REFERENCES `Договор`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Клиент_ПакетДоговор()
        {
            string sql = "ALTER TABLE `ПакетДоговор` ADD INDEX (`КодКлиент`)";
            return sql;
        }
        public string Relation_Клиент_ПакетДоговор()
        {
            string sql = "ALTER TABLE `ПакетДоговор` ADD FOREIGN KEY (`КодКлиент`) REFERENCES `Клиент`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Примечания_ПакетДоговор()
        {
            string sql = "ALTER TABLE `ПакетДоговор` ADD INDEX (`КодПримечания`)";
            return sql;
        }
        public string Relation_Примечания_ПакетДоговор()
        {
            string sql = "ALTER TABLE `ПакетДоговор` ADD FOREIGN KEY (`КодПримечания`) REFERENCES `Примечания`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_ПакетДоговор_ПакетДоговорЖурнал()
        {
            string sql = "ALTER TABLE `ПакетДоговорЖурнал` ADD INDEX (`КодПакетДоговор`)";
            return sql;
        }
        public string Relation_ПакетДоговор_ПакетДоговорЖурнал()
        {
            string sql = "ALTER TABLE `ПакетДоговорЖурнал` ADD FOREIGN KEY (`КодПакетДоговор`) REFERENCES `ПакетДоговор`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Типсобытияпакета_ПакетДоговорЖурнал()
        {
            string sql = "ALTER TABLE `ПакетДоговорЖурнал` ADD INDEX (`КодТипсобытияпакета`)";
            return sql;
        }
        public string Relation_Типсобытияпакета_ПакетДоговорЖурнал()
        {
            string sql = "ALTER TABLE `ПакетДоговорЖурнал` ADD FOREIGN KEY (`КодТипсобытияпакета`) REFERENCES `Тип события пакета`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Клиент_ПакетДоговорОбслуживание()
        {
            string sql = "ALTER TABLE `ПакетДоговорОбслуживание` ADD INDEX (`КодКлиент`)";
            return sql;
        }
        public string Relation_Клиент_ПакетДоговорОбслуживание()
        {
            string sql = "ALTER TABLE `ПакетДоговорОбслуживание` ADD FOREIGN KEY (`КодКлиент`) REFERENCES `Клиент`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_ПакетДоговор_ПакетДоговорОбслуживание()
        {
            string sql = "ALTER TABLE `ПакетДоговорОбслуживание` ADD INDEX (`КодПакетДоговор`)";
            return sql;
        }
        public string Relation_ПакетДоговор_ПакетДоговорОбслуживание()
        {
            string sql = "ALTER TABLE `ПакетДоговорОбслуживание` ADD FOREIGN KEY (`КодПакетДоговор`) REFERENCES `ПакетДоговор`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Период_ПакетДоговорОбслуживание()
        {
            string sql = "ALTER TABLE `ПакетДоговорОбслуживание` ADD INDEX (`КодПериод`)";
            return sql;
        }
        public string Relation_Период_ПакетДоговорОбслуживание()
        {
            string sql = "ALTER TABLE `ПакетДоговорОбслуживание` ADD FOREIGN KEY (`КодПериод`) REFERENCES `Период`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Номенклатура_ПакетДоговорОбслуживание()
        {
            string sql = "ALTER TABLE `ПакетДоговорОбслуживание` ADD INDEX (`КодНоменклатура`)";
            return sql;
        }
        public string Relation_Номенклатура_ПакетДоговорОбслуживание()
        {
            string sql = "ALTER TABLE `ПакетДоговорОбслуживание` ADD FOREIGN KEY (`КодНоменклатура`) REFERENCES `Номенклатура`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Пакет_ПакетДоговорСкидка()
        {
            string sql = "ALTER TABLE `ПакетДоговорСкидка` ADD INDEX (`КодПакет`)";
            return sql;
        }
        public string Relation_Пакет_ПакетДоговорСкидка()
        {
            string sql = "ALTER TABLE `ПакетДоговорСкидка` ADD FOREIGN KEY (`КодПакет`) REFERENCES `Пакет`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Скидка_ПакетДоговорСкидка()
        {
            string sql = "ALTER TABLE `ПакетДоговорСкидка` ADD INDEX (`КодСкидка`)";
            return sql;
        }
        public string Relation_Скидка_ПакетДоговорСкидка()
        {
            string sql = "ALTER TABLE `ПакетДоговорСкидка` ADD FOREIGN KEY (`КодСкидка`) REFERENCES `Скидка`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Пакет_ПакетНоменклатура()
        {
            string sql = "ALTER TABLE `ПакетНоменклатура` ADD INDEX (`КодПакет`)";
            return sql;
        }
        public string Relation_Пакет_ПакетНоменклатура()
        {
            string sql = "ALTER TABLE `ПакетНоменклатура` ADD FOREIGN KEY (`КодПакет`) REFERENCES `Пакет`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Номенклатура_ПакетНоменклатура()
        {
            string sql = "ALTER TABLE `ПакетНоменклатура` ADD INDEX (`КодНоменклатура`)";
            return sql;
        }
        public string Relation_Номенклатура_ПакетНоменклатура()
        {
            string sql = "ALTER TABLE `ПакетНоменклатура` ADD FOREIGN KEY (`КодНоменклатура`) REFERENCES `Номенклатура`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Поставщик_Персонал()
        {
            string sql = "ALTER TABLE `Персонал` ADD INDEX (`КодПоставщик`)";
            return sql;
        }
        public string Relation_Поставщик_Персонал()
        {
            string sql = "ALTER TABLE `Персонал` ADD FOREIGN KEY (`КодПоставщик`) REFERENCES `Поставщик`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Должность_Персонал()
        {
            string sql = "ALTER TABLE `Персонал` ADD INDEX (`КодДолжность`)";
            return sql;
        }
        public string Relation_Должность_Персонал()
        {
            string sql = "ALTER TABLE `Персонал` ADD FOREIGN KEY (`КодДолжность`) REFERENCES `Должность`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Клиент_Плательщик()
        {
            string sql = "ALTER TABLE `Плательщик` ADD INDEX (`КодКлиент`)";
            return sql;
        }
        public string Relation_Клиент_Плательщик()
        {
            string sql = "ALTER TABLE `Плательщик` ADD FOREIGN KEY (`КодКлиент`) REFERENCES `Клиент`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Примечания_Плательщик()
        {
            string sql = "ALTER TABLE `Плательщик` ADD INDEX (`КодПримечания`)";
            return sql;
        }
        public string Relation_Примечания_Плательщик()
        {
            string sql = "ALTER TABLE `Плательщик` ADD FOREIGN KEY (`КодПримечания`) REFERENCES `Примечания`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Плательщик_Плательщик_Клиент()
        {
            string sql = "ALTER TABLE `Плательщик-Клиент` ADD INDEX (`КодПлательщик`)";
            return sql;
        }
        public string Relation_Плательщик_Плательщик_Клиент()
        {
            string sql = "ALTER TABLE `Плательщик-Клиент` ADD FOREIGN KEY (`КодПлательщик`) REFERENCES `Плательщик`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Клиент_Плательщик_Клиент()
        {
            string sql = "ALTER TABLE `Плательщик-Клиент` ADD INDEX (`КодКлиент`)";
            return sql;
        }
        public string Relation_Клиент_Плательщик_Клиент()
        {
            string sql = "ALTER TABLE `Плательщик-Клиент` ADD FOREIGN KEY (`КодКлиент`) REFERENCES `Клиент`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Продажа_Позиция()
        {
            string sql = "ALTER TABLE `Позиция` ADD INDEX (`КодПродажа`)";
            return sql;
        }
        public string Relation_Продажа_Позиция()
        {
            string sql = "ALTER TABLE `Позиция` ADD FOREIGN KEY (`КодПродажа`) REFERENCES `Продажа`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Продукт_Позиция()
        {
            string sql = "ALTER TABLE `Позиция` ADD INDEX (`КодПродукт`)";
            return sql;
        }
        public string Relation_Продукт_Позиция()
        {
            string sql = "ALTER TABLE `Позиция` ADD FOREIGN KEY (`КодПродукт`) REFERENCES `Продукт`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Период_Позиция()
        {
            string sql = "ALTER TABLE `Позиция` ADD INDEX (`КодПериод`)";
            return sql;
        }
        public string Relation_Период_Позиция()
        {
            string sql = "ALTER TABLE `Позиция` ADD FOREIGN KEY (`КодПериод`) REFERENCES `Период`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Позиция_ПозицияСкидка()
        {
            string sql = "ALTER TABLE `ПозицияСкидка` ADD INDEX (`КодПозиция`)";
            return sql;
        }
        public string Relation_Позиция_ПозицияСкидка()
        {
            string sql = "ALTER TABLE `ПозицияСкидка` ADD FOREIGN KEY (`КодПозиция`) REFERENCES `Позиция`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Скидка_ПозицияСкидка()
        {
            string sql = "ALTER TABLE `ПозицияСкидка` ADD INDEX (`КодСкидка`)";
            return sql;
        }
        public string Relation_Скидка_ПозицияСкидка()
        {
            string sql = "ALTER TABLE `ПозицияСкидка` ADD FOREIGN KEY (`КодСкидка`) REFERENCES `Скидка`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Роль_Пользователь()
        {
            string sql = "ALTER TABLE `Пользователь` ADD INDEX (`КодРоль`)";
            return sql;
        }
        public string Relation_Роль_Пользователь()
        {
            string sql = "ALTER TABLE `Пользователь` ADD FOREIGN KEY (`КодРоль`) REFERENCES `Роль`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Примечания_Пользователь()
        {
            string sql = "ALTER TABLE `Пользователь` ADD INDEX (`КодПримечания`)";
            return sql;
        }
        public string Relation_Примечания_Пользователь()
        {
            string sql = "ALTER TABLE `Пользователь` ADD FOREIGN KEY (`КодПримечания`) REFERENCES `Примечания`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Клиент_Поставщик()
        {
            string sql = "ALTER TABLE `Поставщик` ADD INDEX (`КодКлиент`)";
            return sql;
        }
        public string Relation_Клиент_Поставщик()
        {
            string sql = "ALTER TABLE `Поставщик` ADD FOREIGN KEY (`КодКлиент`) REFERENCES `Клиент`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Примечания_Поставщик()
        {
            string sql = "ALTER TABLE `Поставщик` ADD INDEX (`КодПримечания`)";
            return sql;
        }
        public string Relation_Примечания_Поставщик()
        {
            string sql = "ALTER TABLE `Поставщик` ADD FOREIGN KEY (`КодПримечания`) REFERENCES `Примечания`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Раздел_Прайслист()
        {
            string sql = "ALTER TABLE `Прайслист` ADD INDEX (`КодРаздел`)";
            return sql;
        }
        public string Relation_Раздел_Прайслист()
        {
            string sql = "ALTER TABLE `Прайслист` ADD FOREIGN KEY (`КодРаздел`) REFERENCES `Раздел`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Таблицы_Примечания()
        {
            string sql = "ALTER TABLE `Примечания` ADD INDEX (`КодТаблицы`)";
            return sql;
        }
        public string Relation_Таблицы_Примечания()
        {
            string sql = "ALTER TABLE `Примечания` ADD FOREIGN KEY (`КодТаблицы`) REFERENCES `Таблицы`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_ТипПРО_Приходник()
        {
            string sql = "ALTER TABLE `Приходник` ADD INDEX (`КодТипПРО`)";
            return sql;
        }
        public string Relation_ТипПРО_Приходник()
        {
            string sql = "ALTER TABLE `Приходник` ADD FOREIGN KEY (`КодТипПРО`) REFERENCES `Тип ПРО`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Клиент_Приходник()
        {
            string sql = "ALTER TABLE `Приходник` ADD INDEX (`КодКлиент`)";
            return sql;
        }
        public string Relation_Клиент_Приходник()
        {
            string sql = "ALTER TABLE `Приходник` ADD FOREIGN KEY (`КодКлиент`) REFERENCES `Клиент`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Приходник_ПриходникДоговор()
        {
            string sql = "ALTER TABLE `ПриходникДоговор` ADD INDEX (`КодПриходник`)";
            return sql;
        }
        public string Relation_Приходник_ПриходникДоговор()
        {
            string sql = "ALTER TABLE `ПриходникДоговор` ADD FOREIGN KEY (`КодПриходник`) REFERENCES `Приходник`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Договор_ПриходникДоговор()
        {
            string sql = "ALTER TABLE `ПриходникДоговор` ADD INDEX (`КодДоговор`)";
            return sql;
        }
        public string Relation_Договор_ПриходникДоговор()
        {
            string sql = "ALTER TABLE `ПриходникДоговор` ADD FOREIGN KEY (`КодДоговор`) REFERENCES `Договор`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Клиент_Продажа()
        {
            string sql = "ALTER TABLE `Продажа` ADD INDEX (`КодКлиент`)";
            return sql;
        }
        public string Relation_Клиент_Продажа()
        {
            string sql = "ALTER TABLE `Продажа` ADD FOREIGN KEY (`КодКлиент`) REFERENCES `Клиент`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Договор_Продажа()
        {
            string sql = "ALTER TABLE `Продажа` ADD INDEX (`КодДоговор`)";
            return sql;
        }
        public string Relation_Договор_Продажа()
        {
            string sql = "ALTER TABLE `Продажа` ADD FOREIGN KEY (`КодДоговор`) REFERENCES `Договор`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Прайслист_Продукт()
        {
            string sql = "ALTER TABLE `Продукт` ADD INDEX (`КодПрайслист`)";
            return sql;
        }
        public string Relation_Прайслист_Продукт()
        {
            string sql = "ALTER TABLE `Продукт` ADD FOREIGN KEY (`КодПрайслист`) REFERENCES `Прайслист`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Номенклатура_Продукт()
        {
            string sql = "ALTER TABLE `Продукт` ADD INDEX (`КодНоменклатура`)";
            return sql;
        }
        public string Relation_Номенклатура_Продукт()
        {
            string sql = "ALTER TABLE `Продукт` ADD FOREIGN KEY (`КодНоменклатура`) REFERENCES `Номенклатура`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Типреквизита_Реквизит()
        {
            string sql = "ALTER TABLE `Реквизит` ADD INDEX (`КодТипреквизита`)";
            return sql;
        }
        public string Relation_Типреквизита_Реквизит()
        {
            string sql = "ALTER TABLE `Реквизит` ADD FOREIGN KEY (`КодТипреквизита`) REFERENCES `Тип реквизита`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Клиент_Реквизит()
        {
            string sql = "ALTER TABLE `Реквизит` ADD INDEX (`КодКлиент`)";
            return sql;
        }
        public string Relation_Клиент_Реквизит()
        {
            string sql = "ALTER TABLE `Реквизит` ADD FOREIGN KEY (`КодКлиент`) REFERENCES `Клиент`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Примечания_Реквизит()
        {
            string sql = "ALTER TABLE `Реквизит` ADD INDEX (`КодПримечания`)";
            return sql;
        }
        public string Relation_Примечания_Реквизит()
        {
            string sql = "ALTER TABLE `Реквизит` ADD FOREIGN KEY (`КодПримечания`) REFERENCES `Примечания`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Примечания_Роль()
        {
            string sql = "ALTER TABLE `Роль` ADD INDEX (`КодПримечания`)";
            return sql;
        }
        public string Relation_Примечания_Роль()
        {
            string sql = "ALTER TABLE `Роль` ADD FOREIGN KEY (`КодПримечания`) REFERENCES `Примечания`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Типскидки_Скидка()
        {
            string sql = "ALTER TABLE `Скидка` ADD INDEX (`КодТипскидки`)";
            return sql;
        }
        public string Relation_Типскидки_Скидка()
        {
            string sql = "ALTER TABLE `Скидка` ADD FOREIGN KEY (`КодТипскидки`) REFERENCES `Тип скидки`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Позиция_Строка()
        {
            string sql = "ALTER TABLE `Строка` ADD INDEX (`КодПозиция`)";
            return sql;
        }
        public string Relation_Позиция_Строка()
        {
            string sql = "ALTER TABLE `Строка` ADD FOREIGN KEY (`КодПозиция`) REFERENCES `Позиция`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Типединицы_Строка()
        {
            string sql = "ALTER TABLE `Строка` ADD INDEX (`КодТипединицы`)";
            return sql;
        }
        public string Relation_Типединицы_Строка()
        {
            string sql = "ALTER TABLE `Строка` ADD FOREIGN KEY (`КодТипединицы`) REFERENCES `Тип единицы`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Продажа_Счет()
        {
            string sql = "ALTER TABLE `Счет` ADD INDEX (`КодПродажа`)";
            return sql;
        }
        public string Relation_Продажа_Счет()
        {
            string sql = "ALTER TABLE `Счет` ADD FOREIGN KEY (`КодПродажа`) REFERENCES `Продажа`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Счет_СчетПозиция()
        {
            string sql = "ALTER TABLE `СчетПозиция` ADD INDEX (`КодСчет`)";
            return sql;
        }
        public string Relation_Счет_СчетПозиция()
        {
            string sql = "ALTER TABLE `СчетПозиция` ADD FOREIGN KEY (`КодСчет`) REFERENCES `Счет`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Позиция_СчетПозиция()
        {
            string sql = "ALTER TABLE `СчетПозиция` ADD INDEX (`КодПозиция`)";
            return sql;
        }
        public string Relation_Позиция_СчетПозиция()
        {
            string sql = "ALTER TABLE `СчетПозиция` ADD FOREIGN KEY (`КодПозиция`) REFERENCES `Позиция`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Счет_СчетСтрока()
        {
            string sql = "ALTER TABLE `СчетСтрока` ADD INDEX (`КодСчет`)";
            return sql;
        }
        public string Relation_Счет_СчетСтрока()
        {
            string sql = "ALTER TABLE `СчетСтрока` ADD FOREIGN KEY (`КодСчет`) REFERENCES `Счет`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Строка_СчетСтрока()
        {
            string sql = "ALTER TABLE `СчетСтрока` ADD INDEX (`КодСтрока`)";
            return sql;
        }
        public string Relation_Строка_СчетСтрока()
        {
            string sql = "ALTER TABLE `СчетСтрока` ADD FOREIGN KEY (`КодСтрока`) REFERENCES `Строка`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Поставщик_Типдоговора()
        {
            string sql = "ALTER TABLE `Тип договора` ADD INDEX (`КодПоставщик`)";
            return sql;
        }
        public string Relation_Поставщик_Типдоговора()
        {
            string sql = "ALTER TABLE `Тип договора` ADD FOREIGN KEY (`КодПоставщик`) REFERENCES `Поставщик`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Дилер_Типдоговора()
        {
            string sql = "ALTER TABLE `Тип договора` ADD INDEX (`КодДилер`)";
            return sql;
        }
        public string Relation_Дилер_Типдоговора()
        {
            string sql = "ALTER TABLE `Тип договора` ADD FOREIGN KEY (`КодДилер`) REFERENCES `Дилер`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Клиент_ТоварАО()
        {
            string sql = "ALTER TABLE `ТоварАО` ADD INDEX (`КодКлиент`)";
            return sql;
        }
        public string Relation_Клиент_ТоварАО()
        {
            string sql = "ALTER TABLE `ТоварАО` ADD FOREIGN KEY (`КодКлиент`) REFERENCES `Клиент`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Договор_ТоварАО()
        {
            string sql = "ALTER TABLE `ТоварАО` ADD INDEX (`КодДоговор`)";
            return sql;
        }
        public string Relation_Договор_ТоварАО()
        {
            string sql = "ALTER TABLE `ТоварАО` ADD FOREIGN KEY (`КодДоговор`) REFERENCES `Договор`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Номенклатура_ТоварАО()
        {
            string sql = "ALTER TABLE `ТоварАО` ADD INDEX (`КодНоменклатура`)";
            return sql;
        }
        public string Relation_Номенклатура_ТоварАО()
        {
            string sql = "ALTER TABLE `ТоварАО` ADD FOREIGN KEY (`КодНоменклатура`) REFERENCES `Номенклатура`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Цена_ТоварАО()
        {
            string sql = "ALTER TABLE `ТоварАО` ADD INDEX (`КодЦена`)";
            return sql;
        }
        public string Relation_Цена_ТоварАО()
        {
            string sql = "ALTER TABLE `ТоварАО` ADD FOREIGN KEY (`КодЦена`) REFERENCES `Цена`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Примечания_ТоварАО()
        {
            string sql = "ALTER TABLE `ТоварАО` ADD INDEX (`КодПримечания`)";
            return sql;
        }
        public string Relation_Примечания_ТоварАО()
        {
            string sql = "ALTER TABLE `ТоварАО` ADD FOREIGN KEY (`КодПримечания`) REFERENCES `Примечания`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Позиция_ТоварАО()
        {
            string sql = "ALTER TABLE `ТоварАО` ADD INDEX (`КодПозиция`)";
            return sql;
        }
        public string Relation_Позиция_ТоварАО()
        {
            string sql = "ALTER TABLE `ТоварАО` ADD FOREIGN KEY (`КодПозиция`) REFERENCES `Позиция`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_ТоварАО_ТоварАОПериод()
        {
            string sql = "ALTER TABLE `ТоварАОПериод` ADD INDEX (`КодТоварАО`)";
            return sql;
        }
        public string Relation_ТоварАО_ТоварАОПериод()
        {
            string sql = "ALTER TABLE `ТоварАОПериод` ADD FOREIGN KEY (`КодТоварАО`) REFERENCES `ТоварАО `(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Позиция_ТоварАОПериод()
        {
            string sql = "ALTER TABLE `ТоварАОПериод` ADD INDEX (`КодПозиция`)";
            return sql;
        }
        public string Relation_Позиция_ТоварАОПериод()
        {
            string sql = "ALTER TABLE `ТоварАОПериод` ADD FOREIGN KEY (`КодПозиция`) REFERENCES `Позиция`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Период_ТоварАОПериод()
        {
            string sql = "ALTER TABLE `ТоварАОПериод` ADD INDEX (`КодПериод`)";
            return sql;
        }
        public string Relation_Период_ТоварАОПериод()
        {
            string sql = "ALTER TABLE `ТоварАОПериод` ADD FOREIGN KEY (`КодПериод`) REFERENCES `Период`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_ТоварАО_ТоварАОСтатус()
        {
            string sql = "ALTER TABLE `ТоварАОСтатус` ADD INDEX (`КодТоварАО`)";
            return sql;
        }
        public string Relation_ТоварАО_ТоварАОСтатус()
        {
            string sql = "ALTER TABLE `ТоварАОСтатус` ADD FOREIGN KEY (`КодТоварАО`) REFERENCES `ТоварАО `(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_ТипстатусаАО_ТоварАОСтатус()
        {
            string sql = "ALTER TABLE `ТоварАОСтатус` ADD INDEX (`КодТипстатусаАО`)";
            return sql;
        }
        public string Relation_ТипстатусаАО_ТоварАОСтатус()
        {
            string sql = "ALTER TABLE `ТоварАОСтатус` ADD FOREIGN KEY (`КодТипстатусаАО`) REFERENCES `Тип статуса АО`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Примечания_ТоварАОСтатус()
        {
            string sql = "ALTER TABLE `ТоварАОСтатус` ADD INDEX (`КодПримечания`)";
            return sql;
        }
        public string Relation_Примечания_ТоварАОСтатус()
        {
            string sql = "ALTER TABLE `ТоварАОСтатус` ADD FOREIGN KEY (`КодПримечания`) REFERENCES `Примечания`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_ТипЭД2_УчетныеданныеЭД2()
        {
            string sql = "ALTER TABLE `Учетные данные ЭД2` ADD INDEX (`КодТипЭД2`)";
            return sql;
        }
        public string Relation_ТипЭД2_УчетныеданныеЭД2()
        {
            string sql = "ALTER TABLE `Учетные данные ЭД2` ADD FOREIGN KEY (`КодТипЭД2`) REFERENCES `Тип ЭД2`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Клиент_УчетныеданныеЭД2()
        {
            string sql = "ALTER TABLE `Учетные данные ЭД2` ADD INDEX (`КодКлиент`)";
            return sql;
        }
        public string Relation_Клиент_УчетныеданныеЭД2()
        {
            string sql = "ALTER TABLE `Учетные данные ЭД2` ADD FOREIGN KEY (`КодКлиент`) REFERENCES `Клиент`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Договор_УчетныеданныеЭД2()
        {
            string sql = "ALTER TABLE `Учетные данные ЭД2` ADD INDEX (`КодДоговор`)";
            return sql;
        }
        public string Relation_Договор_УчетныеданныеЭД2()
        {
            string sql = "ALTER TABLE `Учетные данные ЭД2` ADD FOREIGN KEY (`КодДоговор`) REFERENCES `Договор`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Типцены_Цена()
        {
            string sql = "ALTER TABLE `Цена` ADD INDEX (`КодТипцены`)";
            return sql;
        }
        public string Relation_Типцены_Цена()
        {
            string sql = "ALTER TABLE `Цена` ADD FOREIGN KEY (`КодТипцены`) REFERENCES `Тип цены `(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Скидка_Цена()
        {
            string sql = "ALTER TABLE `Цена` ADD INDEX (`КодСкидка`)";
            return sql;
        }
        public string Relation_Скидка_Цена()
        {
            string sql = "ALTER TABLE `Цена` ADD FOREIGN KEY (`КодСкидка`) REFERENCES `Скидка`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Продукт_Цена()
        {
            string sql = "ALTER TABLE `Цена` ADD INDEX (`КодПродукт`)";
            return sql;
        }
        public string Relation_Продукт_Цена()
        {
            string sql = "ALTER TABLE `Цена` ADD FOREIGN KEY (`КодПродукт`) REFERENCES `Продукт`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Клиент_ЭП()
        {
            string sql = "ALTER TABLE `ЭП` ADD INDEX (`КодКлиент`)";
            return sql;
        }
        public string Relation_Клиент_ЭП()
        {
            string sql = "ALTER TABLE `ЭП` ADD FOREIGN KEY (`КодКлиент`) REFERENCES `Клиент`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Договор_ЭП()
        {
            string sql = "ALTER TABLE `ЭП` ADD INDEX (`КодДоговор`)";
            return sql;
        }
        public string Relation_Договор_ЭП()
        {
            string sql = "ALTER TABLE `ЭП` ADD FOREIGN KEY (`КодДоговор`) REFERENCES `Договор`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Декларант_ЭП()
        {
            string sql = "ALTER TABLE `ЭП` ADD INDEX (`КодДекларант`)";
            return sql;
        }
        public string Relation_Декларант_ЭП()
        {
            string sql = "ALTER TABLE `ЭП` ADD FOREIGN KEY (`КодДекларант`) REFERENCES `Декларант`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Примечания_ЭП()
        {
            string sql = "ALTER TABLE `ЭП` ADD INDEX (`КодПримечания`)";
            return sql;
        }
        public string Relation_Примечания_ЭП()
        {
            string sql = "ALTER TABLE `ЭП` ADD FOREIGN KEY (`КодПримечания`) REFERENCES `Примечания`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }

    }
}

