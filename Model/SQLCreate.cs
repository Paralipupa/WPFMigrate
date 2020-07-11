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
            var _lists = new List<string>
            {
                _sql.Create_Акт(),
                _sql.Create_АктПозиция(),
                _sql.Create_АктСтрока(),
                _sql.Create_Баланс(),
                _sql.Create_Банк(),
                _sql.Create_Город(),
                _sql.Create_ГруппаНоменклатура(),
                _sql.Create_ГруппаПрайслистНоменклатура(),
                _sql.Create_Декларант(),
                _sql.Create_Диадок(),
                _sql.Create_Дилер(),
                _sql.Create_Договор(),
                _sql.Create_Договор_Прайслист(),
                _sql.Create_Договор_Скидка(),
                _sql.Create_Должность(),
                _sql.Create_Журналсообщений(),
                _sql.Create_Журналстатистики(),
                _sql.Create_Журналработы(),
                _sql.Create_Журналзадолженности(),
                _sql.Create_Заявка(),
                _sql.Create_ЗаявкаЭП(),
                _sql.Create_Категория(),
                _sql.Create_Клиент(),
                _sql.Create_Номенклатура(),
                _sql.Create_ОПФ(),
                _sql.Create_Пакет(),
                _sql.Create_Пакет_Номенклатура(),
                _sql.Create_ПакетДоговор(),
                _sql.Create_ПакетДоговорЖурнал(),
                _sql.Create_ПакетДоговорОбслуживание(),
                _sql.Create_ПакетДоговорСкидка(),
                _sql.Create_Период(),
                _sql.Create_Персонал(),
                _sql.Create_Плательщик(),
                _sql.Create_Плательщик_Клиент(),
                _sql.Create_Позиция(),
                _sql.Create_Позиция_Скидка(),
                _sql.Create_Пользователь(),
                _sql.Create_Поставщик(),
                _sql.Create_Прайслист(),
                _sql.Create_Прайслист_Номенклатура(),
                _sql.Create_Признакклиента(),
                _sql.Create_Примечания(),
                _sql.Create_Продажа(),
                _sql.Create_Раздел(),
                _sql.Create_Регион(),
                _sql.Create_РеестрПРО(),
                _sql.Create_РеестрПРОДоговор(),
                _sql.Create_Реквизит(),
                _sql.Create_Роль(),
                _sql.Create_Скидка(),
                _sql.Create_Строка(),
                _sql.Create_Счет(),
                _sql.Create_СчетПозиция(),
                _sql.Create_СчетСтрока(),
                _sql.Create_Таблицы(),
                _sql.Create_Типдоговора(),
                _sql.Create_Типединицы(),
                _sql.Create_Типзаявки(),
                _sql.Create_Типотправкидокумента(),
                _sql.Create_ТипПРО(),
                _sql.Create_Типреквизита(),
                _sql.Create_Типскидки(),
                _sql.Create_Типсобытияпакета(),
                _sql.Create_ТипстатусаАО(),
                _sql.Create_Типцены(),
                _sql.Create_ТипЭД2(),
                _sql.Create_Типверсиипрограммы(),
                _sql.Create_ТоварАО(),
                _sql.Create_ТоварАОПериод(),
                _sql.Create_ТоварАОСтатус(),
                _sql.Create_УчетныеданныеЭД2(),
                _sql.Create_Цена(),
                _sql.Create_ЭП()
            };

            ProgressIndicate progressindicate = new ProgressIndicate(_lists.Count());
            foreach (string _o in _lists)
            {
                try
                {
                    if (token.IsCancellationRequested)
                    {
                        return;
                    }
                    string _name = _o.Substring(13, 50).Substring(1, _o.Substring(14, 50).IndexOf('`'));
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
            var _lists = new List<string>
            {
                _sql.RelationIndex_Акт_АктПозиция(),
                _sql.RelationIndex_Акт_АктСтрока(),
                _sql.RelationIndex_Город_Клиент(),
                _sql.RelationIndex_ГруппаНоменклатура_ГруппаПрайслистНоменклатура(),
                _sql.RelationIndex_Декларант_ЭП(),
                _sql.RelationIndex_Дилер_Типдоговора(),
                _sql.RelationIndex_Договор_Баланс(),
                _sql.RelationIndex_Договор_Договор_Прайслист(),
                _sql.RelationIndex_Договор_Договор_Скидка(),
                _sql.RelationIndex_Договор_Журналзадолженности(),
                _sql.RelationIndex_Договор_ПакетДоговор(),
                _sql.RelationIndex_Договор_Продажа(),
                _sql.RelationIndex_Договор_РеестрПРОДоговор(),
                _sql.RelationIndex_Договор_ТоварАО(),
                _sql.RelationIndex_Договор_УчетныеданныеЭД2(),
                _sql.RelationIndex_Договор_ЭП(),
                _sql.RelationIndex_Должность_Персонал(),
                _sql.RelationIndex_Заявка_ЗаявкаЭП(),
                _sql.RelationIndex_Категория_Номенклатура(),
                _sql.RelationIndex_Клиент_Баланс(),
                _sql.RelationIndex_Клиент_Диадок(),
                _sql.RelationIndex_Клиент_Дилер(),
                _sql.RelationIndex_Клиент_Договор(),
                _sql.RelationIndex_Клиент_Журналзадолженности(),
                _sql.RelationIndex_Клиент_Журналработы(),
                _sql.RelationIndex_Клиент_Журналсообщений(),
                _sql.RelationIndex_Клиент_ПакетДоговор(),
                _sql.RelationIndex_Клиент_ПакетДоговорОбслуживание(),
                _sql.RelationIndex_Клиент_Плательщик(),
                _sql.RelationIndex_Клиент_Плательщик_Клиент(),
                _sql.RelationIndex_Клиент_Поставщик(),
                _sql.RelationIndex_Клиент_Продажа(),
                _sql.RelationIndex_Клиент_РеестрПРО(),
                _sql.RelationIndex_Клиент_Реквизит(),
                _sql.RelationIndex_Клиент_ТоварАО(),
                _sql.RelationIndex_Клиент_УчетныеданныеЭД2(),
                _sql.RelationIndex_Клиент_ЭП(),
                _sql.RelationIndex_Номенклатура_Пакет(),
                _sql.RelationIndex_Номенклатура_Пакет_Номенклатура(),
                _sql.RelationIndex_Номенклатура_ПакетДоговорОбслуживание(),
                _sql.RelationIndex_Номенклатура_Прайслист_Номенклатура(),
                _sql.RelationIndex_Номенклатура_ТоварАО(),
                _sql.RelationIndex_ОПФ_Клиент(),
                _sql.RelationIndex_Пакет_Пакет_Номенклатура(),
                _sql.RelationIndex_Пакет_ПакетДоговор(),
                _sql.RelationIndex_Пакет_ПакетДоговорСкидка(),
                _sql.RelationIndex_ПакетДоговор_ПакетДоговорЖурнал(),
                _sql.RelationIndex_ПакетДоговор_ПакетДоговорОбслуживание(),
                _sql.RelationIndex_Период_ПакетДоговорОбслуживание(),
                _sql.RelationIndex_Период_Позиция(),
                _sql.RelationIndex_Период_ТоварАОПериод(),
                _sql.RelationIndex_Плательщик_Договор(),
                _sql.RelationIndex_Плательщик_Плательщик_Клиент(),
                _sql.RelationIndex_Позиция_АктПозиция(),
                _sql.RelationIndex_Позиция_Позиция_Скидка(),
                _sql.RelationIndex_Позиция_Строка(),
                _sql.RelationIndex_Позиция_СчетПозиция(),
                _sql.RelationIndex_Позиция_ТоварАО(),
                _sql.RelationIndex_Позиция_ТоварАОПериод(),
                _sql.RelationIndex_Пользователь_Журналработы(),
                _sql.RelationIndex_Поставщик_Заявка(),
                _sql.RelationIndex_Поставщик_Персонал(),
                _sql.RelationIndex_Поставщик_Типдоговора(),
                _sql.RelationIndex_Прайслист_Договор_Прайслист(),
                _sql.RelationIndex_Прайслист_Прайслист_Номенклатура(),
                _sql.RelationIndex_Прайслист_Номенклатура_ГруппаПрайслистНоменклатура(),
                _sql.RelationIndex_Прайслист_Номенклатура_Позиция(),
                _sql.RelationIndex_Признакклиента_Клиент(),
                _sql.RelationIndex_Примечания_Баланс(),
                _sql.RelationIndex_Примечания_Дилер(),
                _sql.RelationIndex_Примечания_Договор(),
                _sql.RelationIndex_Примечания_Должность(),
                _sql.RelationIndex_Примечания_Журналзадолженности(),
                _sql.RelationIndex_Примечания_Журналработы(),
                _sql.RelationIndex_Примечания_Журналсообщений(),
                _sql.RelationIndex_Примечания_Журналстатистики(),
                _sql.RelationIndex_Примечания_Клиент(),
                _sql.RelationIndex_Примечания_Номенклатура(),
                _sql.RelationIndex_Примечания_ПакетДоговор(),
                _sql.RelationIndex_Примечания_Плательщик(),
                _sql.RelationIndex_Примечания_Пользователь(),
                _sql.RelationIndex_Примечания_Поставщик(),
                _sql.RelationIndex_Примечания_Реквизит(),
                _sql.RelationIndex_Примечания_Роль(),
                _sql.RelationIndex_Примечания_ТоварАО(),
                _sql.RelationIndex_Примечания_ТоварАОСтатус(),
                _sql.RelationIndex_Примечания_ЭП(),
                _sql.RelationIndex_Продажа_Акт(),
                _sql.RelationIndex_Продажа_Позиция(),
                _sql.RelationIndex_Продажа_Счет(),
                _sql.RelationIndex_Раздел_Договор(),
                _sql.RelationIndex_Раздел_Прайслист(),
                _sql.RelationIndex_Регион_Город(),
                _sql.RelationIndex_РеестрПРО_Баланс(),
                _sql.RelationIndex_РеестрПРО_РеестрПРОДоговор(),
                _sql.RelationIndex_Роль_Пользователь(),
                _sql.RelationIndex_Скидка_Договор_Скидка(),
                _sql.RelationIndex_Скидка_ПакетДоговорСкидка(),
                _sql.RelationIndex_Скидка_Позиция_Скидка(),
                _sql.RelationIndex_Скидка_Цена(),
                _sql.RelationIndex_Строка_АктСтрока(),
                _sql.RelationIndex_Строка_СчетСтрока(),
                _sql.RelationIndex_Счет_СчетПозиция(),
                _sql.RelationIndex_Счет_СчетСтрока(),
                _sql.RelationIndex_Таблицы_Примечания(),
                _sql.RelationIndex_Типдоговора_Договор(),
                _sql.RelationIndex_Типединицы_Номенклатура(),
                _sql.RelationIndex_Типединицы_Строка(),
                _sql.RelationIndex_Типзаявки_Заявка(),
                _sql.RelationIndex_Типотправкидокумента_Договор(),
                _sql.RelationIndex_ТипПРО_РеестрПРО(),
                _sql.RelationIndex_Типреквизита_Реквизит(),
                _sql.RelationIndex_Типскидки_Скидка(),
                _sql.RelationIndex_Типсобытияпакета_ПакетДоговорЖурнал(),
                _sql.RelationIndex_ТипстатусаАО_ТоварАОСтатус(),
                _sql.RelationIndex_Типцены_Цена(),
                _sql.RelationIndex_ТипЭД2_УчетныеданныеЭД2(),
                _sql.RelationIndex_ТоварАО_ТоварАОПериод(),
                _sql.RelationIndex_ТоварАО_ТоварАОСтатус(),
                _sql.RelationIndex_Цена_Пакет(),
                _sql.RelationIndex_Цена_Прайслист_Номенклатура(),
                _sql.RelationIndex_Цена_ТоварАО(),
                _sql.RelationIndex_ЭП_ЗаявкаЭП()
            };

            ProgressIndicate progressindicate = new ProgressIndicate(_lists.Count());
            foreach (string _o in _lists)
            {
                try
                {
                    if (token.IsCancellationRequested)
                    {
                        return;
                    }
                    string _name = _o.Substring(13, 50).Substring(1, _o.Substring(14, 50).IndexOf('`'));
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

    }
}
