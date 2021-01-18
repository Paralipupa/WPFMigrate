using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrateBase.Model
{
    class SQLTemplates
    {


        public string Create_Адрес()
        {
            string nameTable = "Адрес";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Индекс` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Страна` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодРегион` INT NULL DEFAULT NULL";
            sql += ",`Район` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Город` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Населенный пункт` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Улица` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Дом` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Корпус` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Квартира` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодКлиент` INT NULL DEFAULT NULL";
            sql += ",`КодТипАдреса` INT NULL DEFAULT NULL";
            sql += ",`Активный` BIT NULL DEFAULT NULL";
            sql += ",`Дата занесения` DATETIME NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Email()
        {
            string nameTable = "Email";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Баланс()
        {
            string nameTable = "Баланс";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодКлиент` INT NULL DEFAULT NULL";
            sql += ",`КодДоговор` INT NULL DEFAULT NULL";
            sql += ",`Сумма` FLOAT NULL DEFAULT NULL";
            sql += ",`Дата` DATETIME NULL DEFAULT NULL";
            sql += ",`КодДокумент` INT NULL DEFAULT NULL";
            sql += ",`КодПлатежка` INT NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Банк()
        {
            string nameTable = "Банк";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`БИК` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Коррсчет` VARCHAR(150) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_ТипEmail()
        {
            string nameTable = "Тип Email";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_EmailРассылка()
        {
            string nameTable = "EmailРассылка";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодEmail` INT NULL DEFAULT NULL";
            sql += ",`КодТипРассылки` INT NULL DEFAULT NULL";
            sql += ",`Активный` BIT NULL DEFAULT NULL";
            sql += ",`Дата занесения` DATETIME NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Типрассылки()
        {
            string nameTable = "Тип рассылки";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_ТипАдреса()
        {
            string nameTable = "Тип Адреса";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Документ()
        {
            string nameTable = "Документ";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодПродажа` INT NULL DEFAULT NULL";
            sql += ",`Номер` VARCHAR(30) NULL DEFAULT NULL";
            sql += ",`Дата` DATETIME NULL DEFAULT NULL";
            sql += ",`Сумма` FLOAT NULL DEFAULT NULL";
            sql += ",`КодТипДокумента` INT NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_ДокументПозиция()
        {
            string nameTable = "ДокументПозиция";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодДокумент` INT NULL DEFAULT NULL";
            sql += ",`КодПозиция` INT NULL DEFAULT NULL";
            sql += ",`Дата создания` DATETIME NULL DEFAULT NULL";
            sql += ",`$Раздел` VARCHAR(150) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_ДокументСтрока()
        {
            string nameTable = "ДокументСтрока";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодДокумент` INT NULL DEFAULT NULL";
            sql += ",`Порядок` INT NULL DEFAULT NULL";
            sql += ",`Количество` INT NULL DEFAULT NULL";
            sql += ",`Единица измерения` VARCHAR(15) NULL DEFAULT NULL";
            sql += ",`Цена` FLOAT NULL DEFAULT NULL";
            sql += ",`Сумма` FLOAT NULL DEFAULT NULL";
            sql += ",`КодПериод` INT NULL DEFAULT NULL";
            sql += ",`Дата создания` DATETIME NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Журналдокумента()
        {
            string nameTable = "Журнал документа";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодДокумент` INT NULL DEFAULT NULL";
            sql += ",`Учтена` BIT NULL DEFAULT NULL";
            sql += ",`Дата выдачи` DATETIME NULL DEFAULT NULL";
            sql += ",`Получатель` VARCHAR(100) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Город()
        {
            string nameTable = "Город";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодРегион` INT NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Диадок()
        {
            string nameTable = "Диадок";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодКлиент` INT NULL DEFAULT NULL";
            sql += ",`Идентификатор` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Дата начала` DATETIME NULL DEFAULT NULL";
            sql += ",`Дата окончания` DATETIME NULL DEFAULT NULL";
            sql += ",`ID организации` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`ID ящика` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Проверка` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Активный` BIT NULL DEFAULT NULL";
            sql += ",`Дата занесения` DATETIME NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Дилер()
        {
            string nameTable = "Дилер";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодКлиент` INT NULL DEFAULT NULL";
            sql += ",`КодПримечания` INT NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Договор()
        {
            string nameTable = "Договор";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Номер` VARCHAR(50) NULL DEFAULT NULL";
            sql += ",`Дата` DATETIME NULL DEFAULT NULL";
            sql += ",`Дата начала` DATETIME NULL DEFAULT NULL";
            sql += ",`Дата окончания` DATETIME NULL DEFAULT NULL";
            sql += ",`КодТипДоговора` INT NULL DEFAULT NULL";
            sql += ",`КодКлиент` INT NULL DEFAULT NULL";
            sql += ",`КодПлательщик` INT NULL DEFAULT NULL";
            sql += ",`КодПримечания` INT NULL DEFAULT NULL";
            sql += ",`Активный` BIT NULL DEFAULT NULL";
            sql += ",`Дата занесения` DATETIME NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_ДоговорПрайслист()
        {
            string nameTable = "ДоговорПрайслист";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодДоговор` INT NULL DEFAULT NULL";
            sql += ",`Дата начала` DATETIME NULL DEFAULT NULL";
            sql += ",`Дата окончания` DATETIME NULL DEFAULT NULL";
            sql += ",`КодПрайслист` INT NULL DEFAULT NULL";
            sql += ",`Активный` BIT NULL DEFAULT NULL";
            sql += ",`Дата занесения` DATETIME NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_ДоговорСкидка()
        {
            string nameTable = "ДоговорСкидка";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодДоговор` INT NULL DEFAULT NULL";
            sql += ",`КодСкидка` INT NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Должность()
        {
            string nameTable = "Должность";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Дата начала` DATETIME NULL DEFAULT NULL";
            sql += ",`Дата окончания` DATETIME NULL DEFAULT NULL";
            sql += ",`КодПримечания` INT NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Журналработы()
        {
            string nameTable = "Журнал работы";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(250) NULL DEFAULT NULL";
            sql += ",`КодКлиент` INT NULL DEFAULT NULL";
            sql += ",`КодПользователь` INT NULL DEFAULT NULL";
            sql += ",`КодПримечания` INT NULL DEFAULT NULL";
            sql += ",`КодТипрегистрации` INT NULL DEFAULT NULL";
            sql += ",`Дата` DATETIME NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Журналсообщений()
        {
            string nameTable = "Журнал сообщений";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(250) NULL DEFAULT NULL";
            sql += ",`Дата` DATETIME NULL DEFAULT NULL";
            sql += ",`КодКлиент` INT NULL DEFAULT NULL";
            sql += ",`ЭлEmail` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодПримечания` INT NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Журналстатистики()
        {
            string nameTable = "Журнал статистики";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Дата начала` DATETIME NULL DEFAULT NULL";
            sql += ",`Дата окончания` DATETIME NULL DEFAULT NULL";
            sql += ",`КодПримечания` INT NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Заявка()
        {
            string nameTable = "Заявка";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодТипЗаявки` INT NULL DEFAULT NULL";
            sql += ",`Номер` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Дата` DATETIME NULL DEFAULT NULL";
            sql += ",`КодПоставщик` INT NULL DEFAULT NULL";
            sql += ",`Активный` BIT NULL DEFAULT NULL";
            sql += ",`Дата занесения` DATETIME NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_ЗаявкаЭП()
        {
            string nameTable = "ЗаявкаЭП";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодЗаявка` INT NULL DEFAULT NULL";
            sql += ",`КодЭП` INT NULL DEFAULT NULL";
            sql += ",`Дата занесения` DATETIME NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Категория()
        {
            string nameTable = "Категория";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Клиент()
        {
            string nameTable = "Клиент";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Краткое наименование` VARCHAR(50) NULL DEFAULT NULL";
            sql += ",`КодОПФ` INT NULL DEFAULT NULL";
            sql += ",`ИНН` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КПП` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`ОГРН` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодГород` INT NULL DEFAULT NULL";
            sql += ",`КодПримечания` INT NULL DEFAULT NULL";
            sql += ",`КодПризнакКлиента` INT NULL DEFAULT NULL";
            sql += ",`КодТипОтправкиДокумента` INT NULL DEFAULT NULL";
            sql += ",`$Город` VARCHAR(150) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Типпроверки()
        {
            string nameTable = "Тип проверки";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Журналзадолженности()
        {
            string nameTable = "Журнал задолженности";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Дата` DATETIME NULL DEFAULT NULL";
            sql += ",`КодКлиент` INT NULL DEFAULT NULL";
            sql += ",`КодРаздел` INT NULL DEFAULT NULL";
            sql += ",`Активный` BIT NULL DEFAULT NULL";
            sql += ",`КодПримечания` INT NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_ПакетНоменклатура()
        {
            string nameTable = "ПакетНоменклатура";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодПакет` INT NULL DEFAULT NULL";
            sql += ",`КодНоменклатура` INT NULL DEFAULT NULL";
            sql += ",`Количество` INT NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Контакт()
        {
            string nameTable = "Контакт";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Фамилия` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Имя` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Отчество` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Дата занесения` DATETIME NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_КлиентКонтакт()
        {
            string nameTable = "КлиентКонтакт";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодКлиент` INT NULL DEFAULT NULL";
            sql += ",`КодКонтакт` INT NULL DEFAULT NULL";
            sql += ",`Должность` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Активный` BIT NULL DEFAULT NULL";
            sql += ",`Дата занесения` DATETIME NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_КлиентБанк()
        {
            string nameTable = "КлиентБанк";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Расчетный счет` VARCHAR(20) NULL DEFAULT NULL";
            sql += ",`КодКлиент` INT NULL DEFAULT NULL";
            sql += ",`КодБанк` INT NULL DEFAULT NULL";
            sql += ",`Активный` BIT NULL DEFAULT NULL";
            sql += ",`Дата занесения` DATETIME NULL DEFAULT NULL";
            sql += ",`$БИК` VARCHAR(150) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_КонтактEmail()
        {
            string nameTable = "КонтактEmail";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодКонтакт` INT NULL DEFAULT NULL";
            sql += ",`КодEmail` INT NULL DEFAULT NULL";
            sql += ",`КодТипEmail` INT NULL DEFAULT NULL";
            sql += ",`Активный` BIT NULL DEFAULT NULL";
            sql += ",`Дата занесения` DATETIME NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_КлиентКонтактEmail()
        {
            string nameTable = "КлиентКонтактEmail";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодКлиентКонтакт` INT NULL DEFAULT NULL";
            sql += ",`КодEmail` INT NULL DEFAULT NULL";
            sql += ",`КодТипEmail` INT NULL DEFAULT NULL";
            sql += ",`Активный` BIT NULL DEFAULT NULL";
            sql += ",`Дата занесения` DATETIME NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_КлиентEmail()
        {
            string nameTable = "КлиентEmail";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодКлиент` INT NULL DEFAULT NULL";
            sql += ",`КодEmail` INT NULL DEFAULT NULL";
            sql += ",`КодТипEmail` INT NULL DEFAULT NULL";
            sql += ",`Активный` BIT NULL DEFAULT NULL";
            sql += ",`Дата занесения` DATETIME NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Проверка()
        {
            string nameTable = "Проверка";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодКлиент` INT NULL DEFAULT NULL";
            sql += ",`КодТипПроверки` INT NULL DEFAULT NULL";
            sql += ",`Активный` BIT NULL DEFAULT NULL";
            sql += ",`Дата` DATETIME NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_КонтактТелефон()
        {
            string nameTable = "КонтактТелефон";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодКонтакт` INT NULL DEFAULT NULL";
            sql += ",`КодТелефон` INT NULL DEFAULT NULL";
            sql += ",`Активный` BIT NULL DEFAULT NULL";
            sql += ",`Дата занесения` DATETIME NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_КлиентКонтактТелефон()
        {
            string nameTable = "КлиентКонтактТелефон";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодКлиентКонтакт` INT NULL DEFAULT NULL";
            sql += ",`КодТелефон` INT NULL DEFAULT NULL";
            sql += ",`Активный` BIT NULL DEFAULT NULL";
            sql += ",`Дата занесения` DATETIME NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_КлиентТелефон()
        {
            string nameTable = "КлиентТелефон";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодКлиент` INT NULL DEFAULT NULL";
            sql += ",`КодТелефон` INT NULL DEFAULT NULL";
            sql += ",`Активный` BIT NULL DEFAULT NULL";
            sql += ",`Дата занесения` DATETIME NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Номенклатура()
        {
            string nameTable = "Номенклатура";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Краткое наименование` VARCHAR(50) NULL DEFAULT NULL";
            sql += ",`КодТипЕдиницы` INT NULL DEFAULT NULL";
            sql += ",`Описание` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Порядок` INT NULL DEFAULT NULL";
            sql += ",`КодКатегория` INT NULL DEFAULT NULL";
            sql += ",`КодПримечания` INT NULL DEFAULT NULL";
            sql += ",`Активный` BIT NULL DEFAULT NULL";
            sql += ",`Дата занесения` DATETIME NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_ОПФ()
        {
            string nameTable = "ОПФ";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Краткое наименование` VARCHAR(50) NULL DEFAULT NULL";
            sql += ",`Активный` BIT NULL DEFAULT NULL";
            sql += ",`Дата занесения` DATETIME NULL DEFAULT NULL";
            sql += ",`Порядок` INT NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Типпакета()
        {
            string nameTable = "Тип пакета";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Количество` INT NULL DEFAULT NULL";
            sql += ",`КодНоменклатура` INT NULL DEFAULT NULL";
            sql += ",`Активный` BIT NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Пакет()
        {
            string nameTable = "Пакет";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодТиппакета` INT NULL DEFAULT NULL";
            sql += ",`КодКлиент` INT NULL DEFAULT NULL";
            sql += ",`Дата начала` DATETIME NULL DEFAULT NULL";
            sql += ",`Дата окончания` DATETIME NULL DEFAULT NULL";
            sql += ",`Количество` INT NULL DEFAULT NULL";
            sql += ",`Остаток` FLOAT NULL DEFAULT NULL";
            sql += ",`КодПримечания` INT NULL DEFAULT NULL";
            sql += ",`Дата занесения` DATETIME NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_ПакетЖурнал()
        {
            string nameTable = "ПакетЖурнал";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодПакет` INT NULL DEFAULT NULL";
            sql += ",`Количество` INT NULL DEFAULT NULL";
            sql += ",`Дата` DATETIME NULL DEFAULT NULL";
            sql += ",`КодТипСобытияПакета` INT NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_ПакетПериод()
        {
            string nameTable = "ПакетПериод";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодКлиент` INT NULL DEFAULT NULL";
            sql += ",`КодПериод` INT NULL DEFAULT NULL";
            sql += ",`КодНоменклатура` INT NULL DEFAULT NULL";
            sql += ",`Количество` INT NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Период()
        {
            string nameTable = "Период";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
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
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Фамилия` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Имя` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Отчество` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодПоставщик` INT NULL DEFAULT NULL";
            sql += ",`КодДолжность` INT NULL DEFAULT NULL";
            sql += ",`Активный` BIT NULL DEFAULT NULL";
            sql += ",`Дата занесения` DATETIME NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Плательщик()
        {
            string nameTable = "Плательщик";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодКлиент` INT NULL DEFAULT NULL";
            sql += ",`КодПримечания` INT NULL DEFAULT NULL";
            sql += ",`Активный` BIT NULL DEFAULT NULL";
            sql += ",`Дата занесения` DATETIME NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Позиция()
        {
            string nameTable = "Позиция";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодПродажа` INT NULL DEFAULT NULL";
            sql += ",`КодПродукт` INT NULL DEFAULT NULL";
            sql += ",`КодПериод` INT NULL DEFAULT NULL";
            sql += ",`Количество` INT NULL DEFAULT NULL";
            sql += ",`Копия` INT NULL DEFAULT NULL";
            sql += ",`Цена` FLOAT NULL DEFAULT NULL";
            sql += ",`Сумма` FLOAT NULL DEFAULT NULL";
            sql += ",`СуммаСкидки` FLOAT NULL DEFAULT NULL";
            sql += ",`Итого` FLOAT NULL DEFAULT NULL";
            sql += ",`Сетевая` BIT NULL DEFAULT NULL";
            sql += ",`Оплачено` BIT NULL DEFAULT NULL";
            sql += ",`Дата создания` DATETIME NULL DEFAULT NULL";
            sql += ",`КодПозиция` INT NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_ПозицияСкидка()
        {
            string nameTable = "ПозицияСкидка";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодПозиция` INT NULL DEFAULT NULL";
            sql += ",`КодСкидка` INT NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Пользователь()
        {
            string nameTable = "Пользователь";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодРоль` INT NULL DEFAULT NULL";
            sql += ",`КодПримечания` INT NULL DEFAULT NULL";
            sql += ",`Логин` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Пароль` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Активный` BIT NULL DEFAULT NULL";
            sql += ",`Дата занесения` DATETIME NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Поставщик()
        {
            string nameTable = "Поставщик";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодКлиент` INT NULL DEFAULT NULL";
            sql += ",`КодПримечания` INT NULL DEFAULT NULL";
            sql += ",`Активный` BIT NULL DEFAULT NULL";
            sql += ",`Дата занесения` DATETIME NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_ПлательщикКлиент()
        {
            string nameTable = "ПлательщикКлиент";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодПлательщик` INT NULL DEFAULT NULL";
            sql += ",`КодКлиент` INT NULL DEFAULT NULL";
            sql += ",`Активный` BIT NULL DEFAULT NULL";
            sql += ",`Дата занесения` DATETIME NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Прайслист()
        {
            string nameTable = "Прайслист";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Дата начала` DATETIME NULL DEFAULT NULL";
            sql += ",`Дата окончания` DATETIME NULL DEFAULT NULL";
            sql += ",`Порядок` INT NULL DEFAULT NULL";
            sql += ",`Описание` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодРаздел` INT NULL DEFAULT NULL";
            sql += ",`КодПрайслист` INT NULL DEFAULT NULL";
            sql += ",`Активный` BIT NULL DEFAULT NULL";
            sql += ",`Дата занесения` DATETIME NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_ПрайслистТипДоговора()
        {
            string nameTable = "ПрайслистТипДоговора";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодПрайслист` INT NULL DEFAULT NULL";
            sql += ",`КодТипДоговора` INT NULL DEFAULT NULL";
            sql += ",`Активный` BIT NULL DEFAULT NULL";
            sql += ",`Дата занесения` DATETIME NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Телефон()
        {
            string nameTable = "Телефон";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Номер` VARCHAR(11) NULL DEFAULT NULL";
            sql += ",`Активный` BIT NULL DEFAULT NULL";
            sql += ",`Дата занесения` DATETIME NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Группа()
        {
            string nameTable = "Группа";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`$КодПрограммы` INT NULL DEFAULT NULL";
            sql += ",`Порядок` INT NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_ГруппаПродукт()
        {
            string nameTable = "ГруппаПродукт";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодГруппа` INT NULL DEFAULT NULL";
            sql += ",`КодПродукт` INT NULL DEFAULT NULL";
            sql += ",`Уникальный` VARCHAR(150) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Продукт()
        {
            string nameTable = "Продукт";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодПрайслист` INT NULL DEFAULT NULL";
            sql += ",`КодНоменклатура` INT NULL DEFAULT NULL";
            sql += ",`Уникальный` VARCHAR(150) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Признакклиента()
        {
            string nameTable = "Признак клиента";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Примечания()
        {
            string nameTable = "Примечания";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодТаблицы` INT NULL DEFAULT NULL";
            sql += ",`Счетчик` INT NULL DEFAULT NULL";
            sql += ",`Содержание` MEDIUMTEXT NULL DEFAULT NULL";
            sql += ",`Дата` DATETIME NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Продажа()
        {
            string nameTable = "Продажа";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Дата создания` DATETIME NULL DEFAULT NULL";
            sql += ",`Дата расчета` DATETIME NULL DEFAULT NULL";
            sql += ",`Оплачено` BIT NULL DEFAULT NULL";
            sql += ",`КодКлиент` INT NULL DEFAULT NULL";
            sql += ",`КодДоговор` INT NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Раздел()
        {
            string nameTable = "Раздел";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Описание` VARCHAR(150) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Регион()
        {
            string nameTable = "Регион";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Номер региона` VARCHAR(4) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Платежка()
        {
            string nameTable = "Платежка";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`ИНН` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Расчетный счет` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Номер` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Дата` DATETIME NULL DEFAULT NULL";
            sql += ",`Сумма` FLOAT NULL DEFAULT NULL";
            sql += ",`Банк` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Назначение` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодКлиент` INT NULL DEFAULT NULL";
            sql += ",`КодВыписка` INT NULL DEFAULT NULL";
            sql += ",`Учтена` BIT NULL DEFAULT NULL";
            sql += ",`Дата занесения` DATETIME NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_ПлатежкаПродажа()
        {
            string nameTable = "ПлатежкаПродажа";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодПлатежка` INT NULL DEFAULT NULL";
            sql += ",`КодПродажа` INT NULL DEFAULT NULL";
            sql += ",`КодПериод` INT NULL DEFAULT NULL";
            sql += ",`КодРаздел` INT NULL DEFAULT NULL";
            sql += ",`Сумма` FLOAT NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Реквизит()
        {
            string nameTable = "Реквизит";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодТипРеквизита` INT NULL DEFAULT NULL";
            sql += ",`Значение` VARCHAR(250) NULL DEFAULT NULL";
            sql += ",`КодКлиент` INT NULL DEFAULT NULL";
            sql += ",`КодПримечания` INT NULL DEFAULT NULL";
            sql += ",`Учтена` BIT NULL DEFAULT NULL";
            sql += ",`Активный` BIT NULL DEFAULT NULL";
            sql += ",`Дата занесения` DATETIME NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Роль()
        {
            string nameTable = "Роль";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодПримечания` INT NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Скидка()
        {
            string nameTable = "Скидка";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодТипСкидки` INT NULL DEFAULT NULL";
            sql += ",`Размер` FLOAT NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Выписка()
        {
            string nameTable = "Выписка";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Учтена` BIT NULL DEFAULT NULL";
            sql += ",`Дата занесения` DATETIME NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Таблицы()
        {
            string nameTable = "Таблицы";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Описание` VARCHAR(100) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Типверсиипрограммы()
        {
            string nameTable = "Тип версии программы";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Типдоговора()
        {
            string nameTable = "Тип договора";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`НаименованиеПредложное` VARCHAR(50) NULL DEFAULT NULL";
            sql += ",`НаименованиеРодительское` VARCHAR(50) NULL DEFAULT NULL";
            sql += ",`Описание` VARCHAR(100) NULL DEFAULT NULL";
            sql += ",`ФайлШаблона` VARCHAR(100) NULL DEFAULT NULL";
            sql += ",`Префикс` VARCHAR(20) NULL DEFAULT NULL";
            sql += ",`КодРаздел` INT NULL DEFAULT NULL";
            sql += ",`КодПоставщик` INT NULL DEFAULT NULL";
            sql += ",`КодДилер` INT NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Тариф()
        {
            string nameTable = "Тариф";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодРаздел` INT NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_КлиентТариф()
        {
            string nameTable = "КлиентТариф";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодКлиент` INT NULL DEFAULT NULL";
            sql += ",`КодТариф` INT NULL DEFAULT NULL";
            sql += ",`Дата начала` DATETIME NULL DEFAULT NULL";
            sql += ",`Дата окончания` DATETIME NULL DEFAULT NULL";
            sql += ",`Активный` BIT NULL DEFAULT NULL";
            sql += ",`Дата занесения` DATETIME NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Типдокумента()
        {
            string nameTable = "Тип документа";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Типединицы()
        {
            string nameTable = "Тип единицы";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
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
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Типотправкидокумента()
        {
            string nameTable = "Тип отправки документа";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Типреквизита()
        {
            string nameTable = "Тип реквизита";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Порядок` INT NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Типрегистрации()
        {
            string nameTable = "Тип регистрации";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Типскидки()
        {
            string nameTable = "Тип скидки";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Типсобытияпакета()
        {
            string nameTable = "Тип события пакета";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Типстатусатовара()
        {
            string nameTable = "Тип статуса товара";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Типцены()
        {
            string nameTable = "Тип цены";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_ТипЭД2()
        {
            string nameTable = "Тип ЭД2";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Товар()
        {
            string nameTable = "Товар";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодКлиент` INT NULL DEFAULT NULL";
            sql += ",`КодДоговор` INT NULL DEFAULT NULL";
            sql += ",`КодПозиция` INT NULL DEFAULT NULL";
            sql += ",`КодПродукт` INT NULL DEFAULT NULL";
            sql += ",`Сумма` FLOAT NULL DEFAULT NULL";
            sql += ",`Дата` DATETIME NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_ТоварПериод()
        {
            string nameTable = "ТоварПериод";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодТовар` INT NULL DEFAULT NULL";
            sql += ",`КодПозиция` INT NULL DEFAULT NULL";
            sql += ",`КодПериод` INT NULL DEFAULT NULL";
            sql += ",`Количество` INT NULL DEFAULT NULL";
            sql += ",`Сумма` FLOAT NULL DEFAULT NULL";
            sql += ",`Оплачено` BIT NULL DEFAULT NULL";
            sql += ",`Дата создания` DATETIME NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_ТоварСтатус()
        {
            string nameTable = "ТоварСтатус";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодТовар` INT NULL DEFAULT NULL";
            sql += ",`КодТипСтатусаТовара` INT NULL DEFAULT NULL";
            sql += ",`Дата` DATETIME NULL DEFAULT NULL";
            sql += ",`Активный` BIT NULL DEFAULT NULL";
            sql += ",`Дата занесения` DATETIME NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_УчетныеданныеЭД2()
        {
            string nameTable = "Учетные данные ЭД2";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодТипЭД2` INT NULL DEFAULT NULL";
            sql += ",`Дата` DATETIME NULL DEFAULT NULL";
            sql += ",`КодКлиент` INT NULL DEFAULT NULL";
            sql += ",`КодДоговор` INT NULL DEFAULT NULL";
            sql += ",`Активный` BIT NULL DEFAULT NULL";
            sql += ",`Дата занесения` DATETIME NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Цена()
        {
            string nameTable = "Цена";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодТипЦены` INT NULL DEFAULT NULL";
            sql += ",`Количество` INT NULL DEFAULT NULL";
            sql += ",`Копия` INT NULL DEFAULT NULL";
            sql += ",`Сумма` FLOAT NULL DEFAULT NULL";
            sql += ",`КодСкидка` INT NULL DEFAULT NULL";
            sql += ",`КодПродукт` INT NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_ЭП()
        {
            string nameTable = "ЭП";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодКлиент` INT NULL DEFAULT NULL";
            sql += ",`КодДоговор` INT NULL DEFAULT NULL";
            sql += ",`КодДекларант` INT NULL DEFAULT NULL";
            sql += ",`Номер` VARCHAR(30) NULL DEFAULT NULL";
            sql += ",`Дата` DATETIME NULL DEFAULT NULL";
            sql += ",`Дата Получения` DATETIME NULL DEFAULT NULL";
            sql += ",`Активный` BIT NULL DEFAULT NULL";
            sql += ",`Дата занесения` DATETIME NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Декларант()
        {
            string nameTable = "Декларант";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`Фамилия` VARCHAR(50) NULL DEFAULT NULL";
            sql += ",`Имя` VARCHAR(50) NULL DEFAULT NULL";
            sql += ",`Отчество` VARCHAR(50) NULL DEFAULT NULL";
            sql += ",`КодПол` INT NULL DEFAULT NULL";
            sql += ",`Дата рождения` DATETIME NULL DEFAULT NULL";
            sql += ",`Место рождения` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`СНИЛС` VARCHAR(14) NULL DEFAULT NULL";
            sql += ",`КодТелефон` INT NULL DEFAULT NULL";
            sql += ",`КодEmail` INT NULL DEFAULT NULL";
            sql += ",`КодПаспорт` INT NULL DEFAULT NULL";
            sql += ",`Серия` VARCHAR(5) NULL DEFAULT NULL";
            sql += ",`Номер` VARCHAR(10) NULL DEFAULT NULL";
            sql += ",`Дата выдачи` DATETIME NULL DEFAULT NULL";
            sql += ",`Номер подразделения` VARCHAR(7) NULL DEFAULT NULL";
            sql += ",`Кем выдан` VARCHAR(250) NULL DEFAULT NULL";
            sql += ",`Дата занесения` DATETIME NULL DEFAULT NULL";
            sql += ",`$Телефон` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`$Email` VARCHAR(150) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Паспорт()
        {
            string nameTable = "Паспорт";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Пол()
        {
            string nameTable = "Пол";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }

        public string Create_Выборка()
        {
            string nameTable = "Выборка";
            string sql = "CREATE TABLE `" + nameTable + "` (`Код` INT AUTO_INCREMENT PRIMARY KEY";
            sql += ",`Наименование` VARCHAR(150) NULL DEFAULT NULL";
            sql += ",`КодПользователь` INT NULL DEFAULT NULL";
            sql += ",`Дата` DATETIME NULL DEFAULT NULL";
            sql += ",`КодПримечания` INT NULL DEFAULT NULL";
            sql += ")";
            return sql;
        }
        public string RelationIndex_Email_EmailРассылка()
        {
            string sql = "ALTER TABLE `EmailРассылка` ADD INDEX (`КодEmail`)";
            return sql;
        }
        public string Relation_Email_EmailРассылка()
        {
            string sql = "ALTER TABLE `EmailРассылка` ADD FOREIGN KEY (`КодEmail`) REFERENCES `Email`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Типрассылки_EmailРассылка()
        {
            string sql = "ALTER TABLE `EmailРассылка` ADD INDEX (`КодТипрассылки`)";
            return sql;
        }
        public string Relation_Типрассылки_EmailРассылка()
        {
            string sql = "ALTER TABLE `EmailРассылка` ADD FOREIGN KEY (`КодТипрассылки`) REFERENCES `Тип рассылки`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Регион_Адрес()
        {
            string sql = "ALTER TABLE `Адрес` ADD INDEX (`КодРегион`)";
            return sql;
        }
        public string Relation_Регион_Адрес()
        {
            string sql = "ALTER TABLE `Адрес` ADD FOREIGN KEY (`КодРегион`) REFERENCES `Регион`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Клиент_Адрес()
        {
            string sql = "ALTER TABLE `Адрес` ADD INDEX (`КодКлиент`)";
            return sql;
        }
        public string Relation_Клиент_Адрес()
        {
            string sql = "ALTER TABLE `Адрес` ADD FOREIGN KEY (`КодКлиент`) REFERENCES `Клиент`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_ТипАдреса_Адрес()
        {
            string sql = "ALTER TABLE `Адрес` ADD INDEX (`КодТипАдреса`)";
            return sql;
        }
        public string Relation_ТипАдреса_Адрес()
        {
            string sql = "ALTER TABLE `Адрес` ADD FOREIGN KEY (`КодТипАдреса`) REFERENCES `Тип Адреса`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
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
        public string RelationIndex_Документ_Баланс()
        {
            string sql = "ALTER TABLE `Баланс` ADD INDEX (`КодДокумент`)";
            return sql;
        }
        public string Relation_Документ_Баланс()
        {
            string sql = "ALTER TABLE `Баланс` ADD FOREIGN KEY (`КодДокумент`) REFERENCES `Документ`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Платежка_Баланс()
        {
            string sql = "ALTER TABLE `Баланс` ADD INDEX (`КодПлатежка`)";
            return sql;
        }
        public string Relation_Платежка_Баланс()
        {
            string sql = "ALTER TABLE `Баланс` ADD FOREIGN KEY (`КодПлатежка`) REFERENCES `Платежка`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Пользователь_Выборка()
        {
            string sql = "ALTER TABLE `Выборка` ADD INDEX (`КодПользователь`)";
            return sql;
        }
        public string Relation_Пользователь_Выборка()
        {
            string sql = "ALTER TABLE `Выборка` ADD FOREIGN KEY (`КодПользователь`) REFERENCES `Пользователь`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Примечания_Выборка()
        {
            string sql = "ALTER TABLE `Выборка` ADD INDEX (`КодПримечания`)";
            return sql;
        }
        public string Relation_Примечания_Выборка()
        {
            string sql = "ALTER TABLE `Выборка` ADD FOREIGN KEY (`КодПримечания`) REFERENCES `Примечания`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
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
        public string RelationIndex_Пол_Декларант()
        {
            string sql = "ALTER TABLE `Декларант` ADD INDEX (`КодПол`)";
            return sql;
        }
        public string Relation_Пол_Декларант()
        {
            string sql = "ALTER TABLE `Декларант` ADD FOREIGN KEY (`КодПол`) REFERENCES `Пол`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Телефон_Декларант()
        {
            string sql = "ALTER TABLE `Декларант` ADD INDEX (`КодТелефон`)";
            return sql;
        }
        public string Relation_Телефон_Декларант()
        {
            string sql = "ALTER TABLE `Декларант` ADD FOREIGN KEY (`КодТелефон`) REFERENCES `Телефон`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Email_Декларант()
        {
            string sql = "ALTER TABLE `Декларант` ADD INDEX (`КодEmail`)";
            return sql;
        }
        public string Relation_Email_Декларант()
        {
            string sql = "ALTER TABLE `Декларант` ADD FOREIGN KEY (`КодEmail`) REFERENCES `Email`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Паспорт_Декларант()
        {
            string sql = "ALTER TABLE `Декларант` ADD INDEX (`КодПаспорт`)";
            return sql;
        }
        public string Relation_Паспорт_Декларант()
        {
            string sql = "ALTER TABLE `Декларант` ADD FOREIGN KEY (`КодПаспорт`) REFERENCES `Паспорт`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
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
        public string RelationIndex_Продажа_Документ()
        {
            string sql = "ALTER TABLE `Документ` ADD INDEX (`КодПродажа`)";
            return sql;
        }
        public string Relation_Продажа_Документ()
        {
            string sql = "ALTER TABLE `Документ` ADD FOREIGN KEY (`КодПродажа`) REFERENCES `Продажа`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Типдокумента_Документ()
        {
            string sql = "ALTER TABLE `Документ` ADD INDEX (`КодТипдокумента`)";
            return sql;
        }
        public string Relation_Типдокумента_Документ()
        {
            string sql = "ALTER TABLE `Документ` ADD FOREIGN KEY (`КодТипдокумента`) REFERENCES `Тип документа`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Документ_ДокументПозиция()
        {
            string sql = "ALTER TABLE `ДокументПозиция` ADD INDEX (`КодДокумент`)";
            return sql;
        }
        public string Relation_Документ_ДокументПозиция()
        {
            string sql = "ALTER TABLE `ДокументПозиция` ADD FOREIGN KEY (`КодДокумент`) REFERENCES `Документ`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Позиция_ДокументПозиция()
        {
            string sql = "ALTER TABLE `ДокументПозиция` ADD INDEX (`КодПозиция`)";
            return sql;
        }
        public string Relation_Позиция_ДокументПозиция()
        {
            string sql = "ALTER TABLE `ДокументПозиция` ADD FOREIGN KEY (`КодПозиция`) REFERENCES `Позиция`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Документ_ДокументСтрока()
        {
            string sql = "ALTER TABLE `ДокументСтрока` ADD INDEX (`КодДокумент`)";
            return sql;
        }
        public string Relation_Документ_ДокументСтрока()
        {
            string sql = "ALTER TABLE `ДокументСтрока` ADD FOREIGN KEY (`КодДокумент`) REFERENCES `Документ`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Период_ДокументСтрока()
        {
            string sql = "ALTER TABLE `ДокументСтрока` ADD INDEX (`КодПериод`)";
            return sql;
        }
        public string Relation_Период_ДокументСтрока()
        {
            string sql = "ALTER TABLE `ДокументСтрока` ADD FOREIGN KEY (`КодПериод`) REFERENCES `Период`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
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
        public string RelationIndex_Документ_Журналдокумента()
        {
            string sql = "ALTER TABLE `Журнал документа` ADD INDEX (`КодДокумент`)";
            return sql;
        }
        public string Relation_Документ_Журналдокумента()
        {
            string sql = "ALTER TABLE `Журнал документа` ADD FOREIGN KEY (`КодДокумент`) REFERENCES `Документ`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
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
        public string RelationIndex_Раздел_Журналзадолженности()
        {
            string sql = "ALTER TABLE `Журнал задолженности` ADD INDEX (`КодРаздел`)";
            return sql;
        }
        public string Relation_Раздел_Журналзадолженности()
        {
            string sql = "ALTER TABLE `Журнал задолженности` ADD FOREIGN KEY (`КодРаздел`) REFERENCES `Раздел`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
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
        public string RelationIndex_Типрегистрации_Журналработы()
        {
            string sql = "ALTER TABLE `Журнал работы` ADD INDEX (`КодТипрегистрации`)";
            return sql;
        }
        public string Relation_Типрегистрации_Журналработы()
        {
            string sql = "ALTER TABLE `Журнал работы` ADD FOREIGN KEY (`КодТипрегистрации`) REFERENCES `Тип регистрации`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
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
        public string RelationIndex_Типотправкидокумента_Клиент()
        {
            string sql = "ALTER TABLE `Клиент` ADD INDEX (`КодТипотправкидокумента`)";
            return sql;
        }
        public string Relation_Типотправкидокумента_Клиент()
        {
            string sql = "ALTER TABLE `Клиент` ADD FOREIGN KEY (`КодТипотправкидокумента`) REFERENCES `Тип отправки документа`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Клиент_КлиентEmail()
        {
            string sql = "ALTER TABLE `КлиентEmail` ADD INDEX (`КодКлиент`)";
            return sql;
        }
        public string Relation_Клиент_КлиентEmail()
        {
            string sql = "ALTER TABLE `КлиентEmail` ADD FOREIGN KEY (`КодКлиент`) REFERENCES `Клиент`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Email_КлиентEmail()
        {
            string sql = "ALTER TABLE `КлиентEmail` ADD INDEX (`КодEmail`)";
            return sql;
        }
        public string Relation_Email_КлиентEmail()
        {
            string sql = "ALTER TABLE `КлиентEmail` ADD FOREIGN KEY (`КодEmail`) REFERENCES `Email`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_ТипEmail_КлиентEmail()
        {
            string sql = "ALTER TABLE `КлиентEmail` ADD INDEX (`КодТипEmail`)";
            return sql;
        }
        public string Relation_ТипEmail_КлиентEmail()
        {
            string sql = "ALTER TABLE `КлиентEmail` ADD FOREIGN KEY (`КодТипEmail`) REFERENCES `Тип Email`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Клиент_КлиентБанк()
        {
            string sql = "ALTER TABLE `КлиентБанк` ADD INDEX (`КодКлиент`)";
            return sql;
        }
        public string Relation_Клиент_КлиентБанк()
        {
            string sql = "ALTER TABLE `КлиентБанк` ADD FOREIGN KEY (`КодКлиент`) REFERENCES `Клиент`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Банк_КлиентБанк()
        {
            string sql = "ALTER TABLE `КлиентБанк` ADD INDEX (`КодБанк`)";
            return sql;
        }
        public string Relation_Банк_КлиентБанк()
        {
            string sql = "ALTER TABLE `КлиентБанк` ADD FOREIGN KEY (`КодБанк`) REFERENCES `Банк`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Клиент_КлиентКонтакт()
        {
            string sql = "ALTER TABLE `КлиентКонтакт` ADD INDEX (`КодКлиент`)";
            return sql;
        }
        public string Relation_Клиент_КлиентКонтакт()
        {
            string sql = "ALTER TABLE `КлиентКонтакт` ADD FOREIGN KEY (`КодКлиент`) REFERENCES `Клиент`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Контакт_КлиентКонтакт()
        {
            string sql = "ALTER TABLE `КлиентКонтакт` ADD INDEX (`КодКонтакт`)";
            return sql;
        }
        public string Relation_Контакт_КлиентКонтакт()
        {
            string sql = "ALTER TABLE `КлиентКонтакт` ADD FOREIGN KEY (`КодКонтакт`) REFERENCES `Контакт`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_КлиентКонтакт_КлиентКонтактEmail()
        {
            string sql = "ALTER TABLE `КлиентКонтактEmail` ADD INDEX (`КодКлиентКонтакт`)";
            return sql;
        }
        public string Relation_КлиентКонтакт_КлиентКонтактEmail()
        {
            string sql = "ALTER TABLE `КлиентКонтактEmail` ADD FOREIGN KEY (`КодКлиентКонтакт`) REFERENCES `КлиентКонтакт`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Email_КлиентКонтактEmail()
        {
            string sql = "ALTER TABLE `КлиентКонтактEmail` ADD INDEX (`КодEmail`)";
            return sql;
        }
        public string Relation_Email_КлиентКонтактEmail()
        {
            string sql = "ALTER TABLE `КлиентКонтактEmail` ADD FOREIGN KEY (`КодEmail`) REFERENCES `Email`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_ТипEmail_КлиентКонтактEmail()
        {
            string sql = "ALTER TABLE `КлиентКонтактEmail` ADD INDEX (`КодТипEmail`)";
            return sql;
        }
        public string Relation_ТипEmail_КлиентКонтактEmail()
        {
            string sql = "ALTER TABLE `КлиентКонтактEmail` ADD FOREIGN KEY (`КодТипEmail`) REFERENCES `Тип Email`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_КлиентКонтакт_КлиентКонтактТелефон()
        {
            string sql = "ALTER TABLE `КлиентКонтактТелефон` ADD INDEX (`КодКлиентКонтакт`)";
            return sql;
        }
        public string Relation_КлиентКонтакт_КлиентКонтактТелефон()
        {
            string sql = "ALTER TABLE `КлиентКонтактТелефон` ADD FOREIGN KEY (`КодКлиентКонтакт`) REFERENCES `КлиентКонтакт`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Телефон_КлиентКонтактТелефон()
        {
            string sql = "ALTER TABLE `КлиентКонтактТелефон` ADD INDEX (`КодТелефон`)";
            return sql;
        }
        public string Relation_Телефон_КлиентКонтактТелефон()
        {
            string sql = "ALTER TABLE `КлиентКонтактТелефон` ADD FOREIGN KEY (`КодТелефон`) REFERENCES `Телефон`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Клиент_КлиентТариф()
        {
            string sql = "ALTER TABLE `КлиентТариф` ADD INDEX (`КодКлиент`)";
            return sql;
        }
        public string Relation_Клиент_КлиентТариф()
        {
            string sql = "ALTER TABLE `КлиентТариф` ADD FOREIGN KEY (`КодКлиент`) REFERENCES `Клиент`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Тариф_КлиентТариф()
        {
            string sql = "ALTER TABLE `КлиентТариф` ADD INDEX (`КодТариф`)";
            return sql;
        }
        public string Relation_Тариф_КлиентТариф()
        {
            string sql = "ALTER TABLE `КлиентТариф` ADD FOREIGN KEY (`КодТариф`) REFERENCES `Тариф`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Клиент_КлиентТелефон()
        {
            string sql = "ALTER TABLE `КлиентТелефон` ADD INDEX (`КодКлиент`)";
            return sql;
        }
        public string Relation_Клиент_КлиентТелефон()
        {
            string sql = "ALTER TABLE `КлиентТелефон` ADD FOREIGN KEY (`КодКлиент`) REFERENCES `Клиент`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Телефон_КлиентТелефон()
        {
            string sql = "ALTER TABLE `КлиентТелефон` ADD INDEX (`КодТелефон`)";
            return sql;
        }
        public string Relation_Телефон_КлиентТелефон()
        {
            string sql = "ALTER TABLE `КлиентТелефон` ADD FOREIGN KEY (`КодТелефон`) REFERENCES `Телефон`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Контакт_КонтактEmail()
        {
            string sql = "ALTER TABLE `КонтактEmail` ADD INDEX (`КодКонтакт`)";
            return sql;
        }
        public string Relation_Контакт_КонтактEmail()
        {
            string sql = "ALTER TABLE `КонтактEmail` ADD FOREIGN KEY (`КодКонтакт`) REFERENCES `Контакт`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Email_КонтактEmail()
        {
            string sql = "ALTER TABLE `КонтактEmail` ADD INDEX (`КодEmail`)";
            return sql;
        }
        public string Relation_Email_КонтактEmail()
        {
            string sql = "ALTER TABLE `КонтактEmail` ADD FOREIGN KEY (`КодEmail`) REFERENCES `Email`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_ТипEmail_КонтактEmail()
        {
            string sql = "ALTER TABLE `КонтактEmail` ADD INDEX (`КодТипEmail`)";
            return sql;
        }
        public string Relation_ТипEmail_КонтактEmail()
        {
            string sql = "ALTER TABLE `КонтактEmail` ADD FOREIGN KEY (`КодТипEmail`) REFERENCES `Тип Email`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Контакт_КонтактТелефон()
        {
            string sql = "ALTER TABLE `КонтактТелефон` ADD INDEX (`КодКонтакт`)";
            return sql;
        }
        public string Relation_Контакт_КонтактТелефон()
        {
            string sql = "ALTER TABLE `КонтактТелефон` ADD FOREIGN KEY (`КодКонтакт`) REFERENCES `Контакт`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Телефон_КонтактТелефон()
        {
            string sql = "ALTER TABLE `КонтактТелефон` ADD INDEX (`КодТелефон`)";
            return sql;
        }
        public string Relation_Телефон_КонтактТелефон()
        {
            string sql = "ALTER TABLE `КонтактТелефон` ADD FOREIGN KEY (`КодТелефон`) REFERENCES `Телефон`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
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
        public string RelationIndex_Типпакета_Пакет()
        {
            string sql = "ALTER TABLE `Пакет` ADD INDEX (`КодТиппакета`)";
            return sql;
        }
        public string Relation_Типпакета_Пакет()
        {
            string sql = "ALTER TABLE `Пакет` ADD FOREIGN KEY (`КодТиппакета`) REFERENCES `Тип пакета`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Клиент_Пакет()
        {
            string sql = "ALTER TABLE `Пакет` ADD INDEX (`КодКлиент`)";
            return sql;
        }
        public string Relation_Клиент_Пакет()
        {
            string sql = "ALTER TABLE `Пакет` ADD FOREIGN KEY (`КодКлиент`) REFERENCES `Клиент`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Примечания_Пакет()
        {
            string sql = "ALTER TABLE `Пакет` ADD INDEX (`КодПримечания`)";
            return sql;
        }
        public string Relation_Примечания_Пакет()
        {
            string sql = "ALTER TABLE `Пакет` ADD FOREIGN KEY (`КодПримечания`) REFERENCES `Примечания`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Пакет_ПакетЖурнал()
        {
            string sql = "ALTER TABLE `ПакетЖурнал` ADD INDEX (`КодПакет`)";
            return sql;
        }
        public string Relation_Пакет_ПакетЖурнал()
        {
            string sql = "ALTER TABLE `ПакетЖурнал` ADD FOREIGN KEY (`КодПакет`) REFERENCES `Пакет`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Типсобытияпакета_ПакетЖурнал()
        {
            string sql = "ALTER TABLE `ПакетЖурнал` ADD INDEX (`КодТипсобытияпакета`)";
            return sql;
        }
        public string Relation_Типсобытияпакета_ПакетЖурнал()
        {
            string sql = "ALTER TABLE `ПакетЖурнал` ADD FOREIGN KEY (`КодТипсобытияпакета`) REFERENCES `Тип события пакета`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
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
        public string RelationIndex_Клиент_ПакетПериод()
        {
            string sql = "ALTER TABLE `ПакетПериод` ADD INDEX (`КодКлиент`)";
            return sql;
        }
        public string Relation_Клиент_ПакетПериод()
        {
            string sql = "ALTER TABLE `ПакетПериод` ADD FOREIGN KEY (`КодКлиент`) REFERENCES `Клиент`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Период_ПакетПериод()
        {
            string sql = "ALTER TABLE `ПакетПериод` ADD INDEX (`КодПериод`)";
            return sql;
        }
        public string Relation_Период_ПакетПериод()
        {
            string sql = "ALTER TABLE `ПакетПериод` ADD FOREIGN KEY (`КодПериод`) REFERENCES `Период`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Номенклатура_ПакетПериод()
        {
            string sql = "ALTER TABLE `ПакетПериод` ADD INDEX (`КодНоменклатура`)";
            return sql;
        }
        public string Relation_Номенклатура_ПакетПериод()
        {
            string sql = "ALTER TABLE `ПакетПериод` ADD FOREIGN KEY (`КодНоменклатура`) REFERENCES `Номенклатура`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
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
        public string RelationIndex_Клиент_Платежка()
        {
            string sql = "ALTER TABLE `Платежка` ADD INDEX (`КодКлиент`)";
            return sql;
        }
        public string Relation_Клиент_Платежка()
        {
            string sql = "ALTER TABLE `Платежка` ADD FOREIGN KEY (`КодКлиент`) REFERENCES `Клиент`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Выписка_Платежка()
        {
            string sql = "ALTER TABLE `Платежка` ADD INDEX (`КодВыписка`)";
            return sql;
        }
        public string Relation_Выписка_Платежка()
        {
            string sql = "ALTER TABLE `Платежка` ADD FOREIGN KEY (`КодВыписка`) REFERENCES `Выписка`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Платежка_ПлатежкаПродажа()
        {
            string sql = "ALTER TABLE `ПлатежкаПродажа` ADD INDEX (`КодПлатежка`)";
            return sql;
        }
        public string Relation_Платежка_ПлатежкаПродажа()
        {
            string sql = "ALTER TABLE `ПлатежкаПродажа` ADD FOREIGN KEY (`КодПлатежка`) REFERENCES `Платежка`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Продажа_ПлатежкаПродажа()
        {
            string sql = "ALTER TABLE `ПлатежкаПродажа` ADD INDEX (`КодПродажа`)";
            return sql;
        }
        public string Relation_Продажа_ПлатежкаПродажа()
        {
            string sql = "ALTER TABLE `ПлатежкаПродажа` ADD FOREIGN KEY (`КодПродажа`) REFERENCES `Продажа`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Период_ПлатежкаПродажа()
        {
            string sql = "ALTER TABLE `ПлатежкаПродажа` ADD INDEX (`КодПериод`)";
            return sql;
        }
        public string Relation_Период_ПлатежкаПродажа()
        {
            string sql = "ALTER TABLE `ПлатежкаПродажа` ADD FOREIGN KEY (`КодПериод`) REFERENCES `Период`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Раздел_ПлатежкаПродажа()
        {
            string sql = "ALTER TABLE `ПлатежкаПродажа` ADD INDEX (`КодРаздел`)";
            return sql;
        }
        public string Relation_Раздел_ПлатежкаПродажа()
        {
            string sql = "ALTER TABLE `ПлатежкаПродажа` ADD FOREIGN KEY (`КодРаздел`) REFERENCES `Раздел`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
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
        public string RelationIndex_Плательщик_ПлательщикКлиент()
        {
            string sql = "ALTER TABLE `ПлательщикКлиент` ADD INDEX (`КодПлательщик`)";
            return sql;
        }
        public string Relation_Плательщик_ПлательщикКлиент()
        {
            string sql = "ALTER TABLE `ПлательщикКлиент` ADD FOREIGN KEY (`КодПлательщик`) REFERENCES `Плательщик`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Клиент_ПлательщикКлиент()
        {
            string sql = "ALTER TABLE `ПлательщикКлиент` ADD INDEX (`КодКлиент`)";
            return sql;
        }
        public string Relation_Клиент_ПлательщикКлиент()
        {
            string sql = "ALTER TABLE `ПлательщикКлиент` ADD FOREIGN KEY (`КодКлиент`) REFERENCES `Клиент`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
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
        public string RelationIndex_Позиция_Позиция()
        {
            string sql = "ALTER TABLE `Позиция` ADD INDEX (`КодПозиция`)";
            return sql;
        }
        public string Relation_Позиция_Позиция()
        {
            string sql = "ALTER TABLE `Позиция` ADD FOREIGN KEY (`КодПозиция`) REFERENCES `Позиция`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
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
        public string RelationIndex_Прайслист_Прайслист()
        {
            string sql = "ALTER TABLE `Прайслист` ADD INDEX (`КодПрайслист`)";
            return sql;
        }
        public string Relation_Прайслист_Прайслист()
        {
            string sql = "ALTER TABLE `Прайслист` ADD FOREIGN KEY (`КодПрайслист`) REFERENCES `Прайслист`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Прайслист_ПрайслистТипДоговора()
        {
            string sql = "ALTER TABLE `ПрайслистТипДоговора` ADD INDEX (`КодПрайслист`)";
            return sql;
        }
        public string Relation_Прайслист_ПрайслистТипДоговора()
        {
            string sql = "ALTER TABLE `ПрайслистТипДоговора` ADD FOREIGN KEY (`КодПрайслист`) REFERENCES `Прайслист`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Типдоговора_ПрайслистТипДоговора()
        {
            string sql = "ALTER TABLE `ПрайслистТипДоговора` ADD INDEX (`КодТипдоговора`)";
            return sql;
        }
        public string Relation_Типдоговора_ПрайслистТипДоговора()
        {
            string sql = "ALTER TABLE `ПрайслистТипДоговора` ADD FOREIGN KEY (`КодТипдоговора`) REFERENCES `Тип договора `(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
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
        public string RelationIndex_Клиент_Проверка()
        {
            string sql = "ALTER TABLE `Проверка` ADD INDEX (`КодКлиент`)";
            return sql;
        }
        public string Relation_Клиент_Проверка()
        {
            string sql = "ALTER TABLE `Проверка` ADD FOREIGN KEY (`КодКлиент`) REFERENCES `Клиент`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Типпроверки_Проверка()
        {
            string sql = "ALTER TABLE `Проверка` ADD INDEX (`КодТиппроверки`)";
            return sql;
        }
        public string Relation_Типпроверки_Проверка()
        {
            string sql = "ALTER TABLE `Проверка` ADD FOREIGN KEY (`КодТиппроверки`) REFERENCES `Тип проверки`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
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
        public string RelationIndex_Раздел_Тариф()
        {
            string sql = "ALTER TABLE `Тариф` ADD INDEX (`КодРаздел`)";
            return sql;
        }
        public string Relation_Раздел_Тариф()
        {
            string sql = "ALTER TABLE `Тариф` ADD FOREIGN KEY (`КодРаздел`) REFERENCES `Раздел`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Раздел_Типдоговора()
        {
            string sql = "ALTER TABLE `Тип договора` ADD INDEX (`КодРаздел`)";
            return sql;
        }
        public string Relation_Раздел_Типдоговора()
        {
            string sql = "ALTER TABLE `Тип договора` ADD FOREIGN KEY (`КодРаздел`) REFERENCES `Раздел`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
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
        public string RelationIndex_Номенклатура_Типпакета()
        {
            string sql = "ALTER TABLE `Тип пакета` ADD INDEX (`КодНоменклатура`)";
            return sql;
        }
        public string Relation_Номенклатура_Типпакета()
        {
            string sql = "ALTER TABLE `Тип пакета` ADD FOREIGN KEY (`КодНоменклатура`) REFERENCES `Номенклатура`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Клиент_Товар()
        {
            string sql = "ALTER TABLE `Товар` ADD INDEX (`КодКлиент`)";
            return sql;
        }
        public string Relation_Клиент_Товар()
        {
            string sql = "ALTER TABLE `Товар` ADD FOREIGN KEY (`КодКлиент`) REFERENCES `Клиент`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Договор_Товар()
        {
            string sql = "ALTER TABLE `Товар` ADD INDEX (`КодДоговор`)";
            return sql;
        }
        public string Relation_Договор_Товар()
        {
            string sql = "ALTER TABLE `Товар` ADD FOREIGN KEY (`КодДоговор`) REFERENCES `Договор`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Позиция_Товар()
        {
            string sql = "ALTER TABLE `Товар` ADD INDEX (`КодПозиция`)";
            return sql;
        }
        public string Relation_Позиция_Товар()
        {
            string sql = "ALTER TABLE `Товар` ADD FOREIGN KEY (`КодПозиция`) REFERENCES `Позиция`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Продукт_Товар()
        {
            string sql = "ALTER TABLE `Товар` ADD INDEX (`КодПродукт`)";
            return sql;
        }
        public string Relation_Продукт_Товар()
        {
            string sql = "ALTER TABLE `Товар` ADD FOREIGN KEY (`КодПродукт`) REFERENCES `Продукт`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Товар_ТоварПериод()
        {
            string sql = "ALTER TABLE `ТоварПериод` ADD INDEX (`КодТовар`)";
            return sql;
        }
        public string Relation_Товар_ТоварПериод()
        {
            string sql = "ALTER TABLE `ТоварПериод` ADD FOREIGN KEY (`КодТовар`) REFERENCES `Товар`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Позиция_ТоварПериод()
        {
            string sql = "ALTER TABLE `ТоварПериод` ADD INDEX (`КодПозиция`)";
            return sql;
        }
        public string Relation_Позиция_ТоварПериод()
        {
            string sql = "ALTER TABLE `ТоварПериод` ADD FOREIGN KEY (`КодПозиция`) REFERENCES `Позиция`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Период_ТоварПериод()
        {
            string sql = "ALTER TABLE `ТоварПериод` ADD INDEX (`КодПериод`)";
            return sql;
        }
        public string Relation_Период_ТоварПериод()
        {
            string sql = "ALTER TABLE `ТоварПериод` ADD FOREIGN KEY (`КодПериод`) REFERENCES `Период`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Товар_ТоварСтатус()
        {
            string sql = "ALTER TABLE `ТоварСтатус` ADD INDEX (`КодТовар`)";
            return sql;
        }
        public string Relation_Товар_ТоварСтатус()
        {
            string sql = "ALTER TABLE `ТоварСтатус` ADD FOREIGN KEY (`КодТовар`) REFERENCES `Товар`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
            return sql;
        }
        public string RelationIndex_Типстатусатовара_ТоварСтатус()
        {
            string sql = "ALTER TABLE `ТоварСтатус` ADD INDEX (`КодТипстатусатовара`)";
            return sql;
        }
        public string Relation_Типстатусатовара_ТоварСтатус()
        {
            string sql = "ALTER TABLE `ТоварСтатус` ADD FOREIGN KEY (`КодТипстатусатовара`) REFERENCES `Тип статуса товара`(`Код`) ON DELETE RESTRICT ON UPDATE RESTRICT";
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

    }
}

