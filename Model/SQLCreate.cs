using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using MySql.Data.MySqlClient;

namespace MigrateBase.Model
{

    class SQLCreate
    {
        private readonly MySqlCommand _command;
        private readonly SQLTemplates _sql;

        public SQLCreate(MySqlConnection connect)
        {
            _command = new MySqlCommand
            {
                Connection = connect
            };
            SQLTemplates _sqlTemplates = new SQLTemplates();
            _sql = _sqlTemplates;
        }

        public void CreateTables(IProgress<ProgressIndicate> progress, CancellationToken token)
        {
            var lists = new List<string>
            {
         _sql.Create_ED2Watcher(),
         _sql.Create_Email(),
         _sql.Create_EmailРассылка(),
         _sql.Create_Адрес(),
         _sql.Create_Баланс(),
         _sql.Create_Банк(),
         _sql.Create_Выборка(),
         _sql.Create_Выписка(),
         _sql.Create_Город(),
         _sql.Create_Группа(),
         _sql.Create_ГруппаПродукт(),
         _sql.Create_Декларант(),
         _sql.Create_Диадок(),
         _sql.Create_Дилер(),
         _sql.Create_Договор(),
         _sql.Create_ДоговорПрайслист(),
         _sql.Create_ДоговорСкидка(),
         _sql.Create_Документ(),
         _sql.Create_ДокументПозиция(),
         _sql.Create_ДокументСтрока(),
         _sql.Create_Должность(),
         _sql.Create_Доступ(),
         _sql.Create_Журналдокумента(),
         _sql.Create_Журналработы(),
         _sql.Create_Журналсообщений(),
         _sql.Create_Журналстатистики(),
         _sql.Create_Журналзадолженности(),
         _sql.Create_Заявка(),
         _sql.Create_ЗаявкаЭП(),
         _sql.Create_Категория(),
         _sql.Create_Клиент(),
         _sql.Create_КлиентEmail(),
         _sql.Create_КлиентБанк(),
         _sql.Create_КлиентКонтакт(),
         _sql.Create_КлиентКонтактEmail(),
         _sql.Create_КлиентКонтактТелефон(),
         _sql.Create_КлиентТариф(),
         _sql.Create_КлиентТелефон(),
         _sql.Create_Команда(),
         _sql.Create_Контакт(),
         _sql.Create_КонтактEmail(),
         _sql.Create_КонтактТелефон(),
         _sql.Create_Номенклатура(),
         _sql.Create_ОПФ(),
         _sql.Create_Пакет(),
         _sql.Create_ПакетЖурнал(),
         _sql.Create_ПакетНоменклатура(),
         _sql.Create_ПакетПериод(),
         _sql.Create_Паспорт(),
         _sql.Create_Период(),
         _sql.Create_Персонал(),
         _sql.Create_Платежка(),
         _sql.Create_ПлатежкаПродажа(),
         _sql.Create_Плательщик(),
         _sql.Create_ПлательщикКлиент(),
         _sql.Create_Позиция(),
         _sql.Create_ПозицияСкидка(),
         _sql.Create_Пол(),
         _sql.Create_Пользователь(),
         _sql.Create_Поставщик(),
         _sql.Create_Прайслист(),
         _sql.Create_ПрайслистТипДоговора(),
         _sql.Create_Признакклиента(),
         _sql.Create_Примечания(),
         _sql.Create_Проверка(),
         _sql.Create_Продажа(),
         _sql.Create_Продукт(),
         _sql.Create_Раздел(),
         _sql.Create_Регион(),
         _sql.Create_Реквизит(),
         _sql.Create_Роль(),
         _sql.Create_Скидка(),
         _sql.Create_Таблицы(),
         _sql.Create_Тариф(),
         _sql.Create_Телефон(),
         _sql.Create_Типрассылки(),
         _sql.Create_ТипАдреса(),
         _sql.Create_Типпроверки(),
         _sql.Create_Типпакета(),
         _sql.Create_Типверсиипрограммы(),
         _sql.Create_Типдоговора(),
         _sql.Create_Типдокумента(),
         _sql.Create_Типединицы(),
         _sql.Create_Типзаявки(),
         _sql.Create_Типотправкидокумента(),
         _sql.Create_Типреквизита(),
         _sql.Create_Типрегистрации(),
         _sql.Create_Типскидки(),
         _sql.Create_Типсобытияпакета(),
         _sql.Create_Типстатусатовара(),
         _sql.Create_Типцены(),
         _sql.Create_ТипЭД2(),
         _sql.Create_ТипEmail(),
         _sql.Create_Товар(),
         _sql.Create_ТоварПериод(),
         _sql.Create_ТоварСтатус(),
         _sql.Create_УчетныеданныеЭД2(),
         _sql.Create_Цена(),
         _sql.Create_ЭП()
            };
            ProgressIndicate progressindicate = new ProgressIndicate(lists.Count());
            foreach (string _o in lists)
            {
                try
                {
                    if (token.IsCancellationRequested)
                    {
                        return;
                    }
                    string _name = _o.Substring(13).Substring(1, _o.Substring(14).IndexOf('`'));
                    progressindicate.SetName(_name);
                    progressindicate.MoveNextCurrent();
                    _command.CommandText = _o; _command.ExecuteNonQuery();
                }
                catch
                {
                    progressindicate.AddMessage($" Не удалось создать таблицу '{progressindicate.GetName()}'");
                }
                finally
                {
                    if (progress != null) progress.Report(progressindicate);

                }
            }
        }


        public void RelationTables(IProgress<ProgressIndicate> progress, CancellationToken token)
        {
            var lists = new List<string>
            {
         _sql.RelationIndex_Email_EmailРассылка(),
         _sql.RelationIndex_Email_Декларант(),
         _sql.RelationIndex_Email_КлиентEmail(),
         _sql.RelationIndex_Email_КлиентКонтактEmail(),
         _sql.RelationIndex_Email_КонтактEmail(),
         _sql.RelationIndex_Банк_КлиентБанк(),
         _sql.RelationIndex_Выписка_Платежка(),
         _sql.RelationIndex_Город_Клиент(),
         _sql.RelationIndex_Группа_ГруппаПродукт(),
         _sql.RelationIndex_Декларант_ЭП(),
         _sql.RelationIndex_Дилер_Типдоговора(),
         _sql.RelationIndex_Договор_Баланс(),
         _sql.RelationIndex_Договор_ДоговорПрайслист(),
         _sql.RelationIndex_Договор_ДоговорСкидка(),
         _sql.RelationIndex_Договор_Продажа(),
         _sql.RelationIndex_Договор_Товар(),
         _sql.RelationIndex_Договор_УчетныеданныеЭД2(),
         _sql.RelationIndex_Договор_ЭП(),
         _sql.RelationIndex_Документ_Баланс(),
         _sql.RelationIndex_Документ_ДокументПозиция(),
         _sql.RelationIndex_Документ_ДокументСтрока(),
         _sql.RelationIndex_Документ_Журналдокумента(),
         _sql.RelationIndex_Документ_ПакетЖурнал(),
         _sql.RelationIndex_Должность_Персонал(),
         _sql.RelationIndex_Заявка_ЗаявкаЭП(),
         _sql.RelationIndex_Категория_Номенклатура(),
         _sql.RelationIndex_Клиент_ED2Watcher(),
         _sql.RelationIndex_Клиент_Адрес(),
         _sql.RelationIndex_Клиент_Баланс(),
         _sql.RelationIndex_Клиент_Диадок(),
         _sql.RelationIndex_Клиент_Дилер(),
         _sql.RelationIndex_Клиент_Договор(),
         _sql.RelationIndex_Клиент_Журналзадолженности(),
         _sql.RelationIndex_Клиент_Журналработы(),
         _sql.RelationIndex_Клиент_Журналсообщений(),
         _sql.RelationIndex_Клиент_КлиентEmail(),
         _sql.RelationIndex_Клиент_КлиентБанк(),
         _sql.RelationIndex_Клиент_КлиентКонтакт(),
         _sql.RelationIndex_Клиент_КлиентТариф(),
         _sql.RelationIndex_Клиент_КлиентТелефон(),
         _sql.RelationIndex_Клиент_Пакет(),
         _sql.RelationIndex_Клиент_ПакетПериод(),
         _sql.RelationIndex_Клиент_Платежка(),
         _sql.RelationIndex_Клиент_Плательщик(),
         _sql.RelationIndex_Клиент_ПлательщикКлиент(),
         _sql.RelationIndex_Клиент_Поставщик(),
         _sql.RelationIndex_Клиент_Проверка(),
         _sql.RelationIndex_Клиент_Продажа(),
         _sql.RelationIndex_Клиент_Реквизит(),
         _sql.RelationIndex_Клиент_Товар(),
         _sql.RelationIndex_Клиент_УчетныеданныеЭД2(),
         _sql.RelationIndex_Клиент_ЭП(),
         _sql.RelationIndex_КлиентКонтакт_КлиентКонтактEmail(),
         _sql.RelationIndex_КлиентКонтакт_КлиентКонтактТелефон(),
         _sql.RelationIndex_Команда_Доступ(),
         _sql.RelationIndex_Контакт_КлиентКонтакт(),
         _sql.RelationIndex_Контакт_КонтактEmail(),
         _sql.RelationIndex_Контакт_КонтактТелефон(),
         _sql.RelationIndex_Номенклатура_ПакетНоменклатура(),
         _sql.RelationIndex_Номенклатура_ПакетПериод(),
         _sql.RelationIndex_Номенклатура_Продукт(),
         _sql.RelationIndex_Номенклатура_Типпакета(),
         _sql.RelationIndex_ОПФ_Клиент(),
         _sql.RelationIndex_Пакет_ПакетЖурнал(),
         _sql.RelationIndex_Пакет_ПакетНоменклатура(),
         _sql.RelationIndex_Паспорт_Декларант(),
         _sql.RelationIndex_Период_ДокументСтрока(),
         _sql.RelationIndex_Период_ПакетПериод(),
         _sql.RelationIndex_Период_ПлатежкаПродажа(),
         _sql.RelationIndex_Период_Позиция(),
         _sql.RelationIndex_Период_ТоварПериод(),
         _sql.RelationIndex_Платежка_Баланс(),
         _sql.RelationIndex_Платежка_ПлатежкаПродажа(),
         _sql.RelationIndex_Плательщик_Договор(),
         _sql.RelationIndex_Плательщик_ПлательщикКлиент(),
         _sql.RelationIndex_Позиция_ДокументПозиция(),
         _sql.RelationIndex_Позиция_Позиция(),
         _sql.RelationIndex_Позиция_ПозицияСкидка(),
         _sql.RelationIndex_Позиция_Товар(),
         _sql.RelationIndex_Позиция_ТоварПериод(),
         _sql.RelationIndex_Пол_Декларант(),
         _sql.RelationIndex_Пользователь_Выборка(),
         _sql.RelationIndex_Пользователь_Журналработы(),
         _sql.RelationIndex_Поставщик_Заявка(),
         _sql.RelationIndex_Поставщик_Персонал(),
         _sql.RelationIndex_Поставщик_Типдоговора(),
         _sql.RelationIndex_Прайслист_ДоговорПрайслист(),
         _sql.RelationIndex_Прайслист_Прайслист(),
         _sql.RelationIndex_Прайслист_ПрайслистТипДоговора(),
         _sql.RelationIndex_Прайслист_Продукт(),
         _sql.RelationIndex_Признакклиента_Клиент(),
         _sql.RelationIndex_Примечания_Выборка(),
         _sql.RelationIndex_Примечания_Дилер(),
         _sql.RelationIndex_Примечания_Договор(),
         _sql.RelationIndex_Примечания_Должность(),
         _sql.RelationIndex_Примечания_Журналзадолженности(),
         _sql.RelationIndex_Примечания_Журналработы(),
         _sql.RelationIndex_Примечания_Журналсообщений(),
         _sql.RelationIndex_Примечания_Журналстатистики(),
         _sql.RelationIndex_Примечания_Клиент(),
         _sql.RelationIndex_Примечания_Номенклатура(),
         _sql.RelationIndex_Примечания_Пакет(),
         _sql.RelationIndex_Примечания_Плательщик(),
         _sql.RelationIndex_Примечания_Пользователь(),
         _sql.RelationIndex_Примечания_Поставщик(),
         _sql.RelationIndex_Примечания_Реквизит(),
         _sql.RelationIndex_Примечания_Роль(),
         _sql.RelationIndex_Продажа_Документ(),
         _sql.RelationIndex_Продажа_ПлатежкаПродажа(),
         _sql.RelationIndex_Продажа_Позиция(),
         _sql.RelationIndex_Продукт_ГруппаПродукт(),
         _sql.RelationIndex_Продукт_Позиция(),
         _sql.RelationIndex_Продукт_Товар(),
         _sql.RelationIndex_Продукт_Цена(),
         _sql.RelationIndex_Раздел_Журналзадолженности(),
         _sql.RelationIndex_Раздел_ПлатежкаПродажа(),
         _sql.RelationIndex_Раздел_Прайслист(),
         _sql.RelationIndex_Раздел_Тариф(),
         _sql.RelationIndex_Раздел_Типдоговора(),
         _sql.RelationIndex_Регион_Адрес(),
         _sql.RelationIndex_Регион_Город(),
         _sql.RelationIndex_Роль_Доступ(),
         _sql.RelationIndex_Роль_Пользователь(),
         _sql.RelationIndex_Скидка_ДоговорСкидка(),
         _sql.RelationIndex_Скидка_ПозицияСкидка(),
         _sql.RelationIndex_Скидка_Цена(),
         _sql.RelationIndex_Таблицы_Примечания(),
         _sql.RelationIndex_Тариф_КлиентТариф(),
         _sql.RelationIndex_Телефон_Декларант(),
         _sql.RelationIndex_Телефон_КлиентКонтактТелефон(),
         _sql.RelationIndex_Телефон_КлиентТелефон(),
         _sql.RelationIndex_Телефон_КонтактТелефон(),
         _sql.RelationIndex_ТипEmail_КлиентEmail(),
         _sql.RelationIndex_ТипEmail_КлиентКонтактEmail(),
         _sql.RelationIndex_ТипEmail_КонтактEmail(),
         _sql.RelationIndex_ТипАдреса_Адрес(),
         _sql.RelationIndex_Типдоговора_Договор(),
         _sql.RelationIndex_Типдоговора_ПрайслистТипДоговора(),
         _sql.RelationIndex_Типдокумента_Документ(),
         _sql.RelationIndex_Типединицы_Номенклатура(),
         _sql.RelationIndex_Типзаявки_Заявка(),
         _sql.RelationIndex_Типотправкидокумента_Клиент(),
         _sql.RelationIndex_Типпакета_Пакет(),
         _sql.RelationIndex_Типпроверки_Проверка(),
         _sql.RelationIndex_Типрассылки_EmailРассылка(),
         _sql.RelationIndex_Типрегистрации_Журналработы(),
         _sql.RelationIndex_Типрегистрации_Доступ(),
         _sql.RelationIndex_Типреквизита_Реквизит(),
         _sql.RelationIndex_Типскидки_Скидка(),
         _sql.RelationIndex_Типсобытияпакета_ПакетЖурнал(),
         _sql.RelationIndex_Типстатусатовара_ТоварСтатус(),
         _sql.RelationIndex_Типцены_Цена(),
         _sql.RelationIndex_ТипЭД2_УчетныеданныеЭД2(),
         _sql.RelationIndex_Товар_ТоварПериод(),
         _sql.RelationIndex_Товар_ТоварСтатус(),
         _sql.RelationIndex_ЭП_ЗаявкаЭП()
            };
            ProgressIndicate progressindicate = new ProgressIndicate(lists.Count());
            foreach (string _o in lists)
            {
                try
                {
                    if (token.IsCancellationRequested)
                    {
                        return;
                    }
                    string _name = _o.Substring(13).Substring(0, _o.Substring(13).IndexOf('`'));
                    progressindicate.SetName(_name);
                    progressindicate.MoveNextCurrent();
                    _command.CommandText = _o; _command.ExecuteNonQuery();
                }
                catch
                {
                    progressindicate.AddMessage($" Не удалось построить отношение '{progressindicate.GetName()}'");
                }
                finally
                {
                    if (progress != null) progress.Report(progressindicate);

                }
            }
        }

    }
}
