using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WpfApp3.Model
{
    class SQLCreate
    {

        public void CreateTables(MySqlCommand command, SQLTemplates sql, IProgress<ProgressIndicate> progress, CancellationToken token)
        {
            var lists = new List<string>();
            lists.Add(sql.Create_Акт());
            lists.Add(sql.Create_АктПозиция());
            lists.Add(sql.Create_АктСтрока());
            lists.Add(sql.Create_Баланс());
            lists.Add(sql.Create_Банк());
            lists.Add(sql.Create_Город());
            lists.Add(sql.Create_ГруппаНоменклатура());
            lists.Add(sql.Create_ГруппаПрайслистНоменклатура());
            lists.Add(sql.Create_Декларант());
            lists.Add(sql.Create_Диадок());
            lists.Add(sql.Create_Дилер());
            lists.Add(sql.Create_Договор());
            lists.Add(sql.Create_Договор_Прайслист());
            lists.Add(sql.Create_Договор_Скидка());
            lists.Add(sql.Create_Должность());
            lists.Add(sql.Create_Журналсообщений());
            lists.Add(sql.Create_Журналстатистики());
            lists.Add(sql.Create_Журналработы());
            lists.Add(sql.Create_Журналзадолженности());
            lists.Add(sql.Create_Заявка());
            lists.Add(sql.Create_ЗаявкаЭП());
            lists.Add(sql.Create_Категория());
            lists.Add(sql.Create_Клиент());
            lists.Add(sql.Create_Номенклатура());
            lists.Add(sql.Create_ОПФ());
            lists.Add(sql.Create_Пакет());
            lists.Add(sql.Create_Пакет_Номенклатура());
            lists.Add(sql.Create_ПакетДоговор());
            lists.Add(sql.Create_ПакетДоговорЖурнал());
            lists.Add(sql.Create_ПакетДоговорОбслуживание());
            lists.Add(sql.Create_ПакетДоговорСкидка());
            lists.Add(sql.Create_Период());
            lists.Add(sql.Create_Персонал());
            lists.Add(sql.Create_Плательщик());
            lists.Add(sql.Create_Плательщик_Клиент());
            lists.Add(sql.Create_Позиция());
            lists.Add(sql.Create_Позиция_Скидка());
            lists.Add(sql.Create_Пользователь());
            lists.Add(sql.Create_Поставщик());
            lists.Add(sql.Create_Прайслист());
            lists.Add(sql.Create_Прайслист_Номенклатура());
            lists.Add(sql.Create_Признакклиента());
            lists.Add(sql.Create_Примечания());
            lists.Add(sql.Create_Продажа());
            lists.Add(sql.Create_Раздел());
            lists.Add(sql.Create_Регион());
            lists.Add(sql.Create_РеестрПРО());
            lists.Add(sql.Create_РеестрПРОДоговор());
            lists.Add(sql.Create_Реквизит());
            lists.Add(sql.Create_Роль());
            lists.Add(sql.Create_Скидка());
            lists.Add(sql.Create_Строка());
            lists.Add(sql.Create_Счет());
            lists.Add(sql.Create_СчетПозиция());
            lists.Add(sql.Create_СчетСтрока());
            lists.Add(sql.Create_Таблицы());
            lists.Add(sql.Create_Типдоговора());
            lists.Add(sql.Create_Типединицы());
            lists.Add(sql.Create_Типзаявки());
            lists.Add(sql.Create_Типотправкидокумента());
            lists.Add(sql.Create_ТипПРО());
            lists.Add(sql.Create_Типреквизита());
            lists.Add(sql.Create_Типскидки());
            lists.Add(sql.Create_Типсобытияпакета());
            lists.Add(sql.Create_ТипстатусаАО());
            lists.Add(sql.Create_Типцены());
            lists.Add(sql.Create_ТипЭД2());
            lists.Add(sql.Create_Типверсиипрограммы());
            lists.Add(sql.Create_ТоварАО());
            lists.Add(sql.Create_ТоварАОПериод());
            lists.Add(sql.Create_ТоварАОСтатус());
            lists.Add(sql.Create_УчетныеданныеЭД2());
            lists.Add(sql.Create_Цена());
            lists.Add(sql.Create_ЭП());
            int i = 0;
            int total = lists.Count;
            ProgressIndicate p = new ProgressIndicate();
            foreach (string o in lists)
            {
                try
                {
                    if (token.IsCancellationRequested)
                    {
                        return;
                    }
                    if (progress != null)
                    {
                        p.name = o.Substring(11, 20);
                        p.current = i;
                        p.count = total;
                        progress.Report(p);
                        i++;
                    }
                    command.CommandText = o; command.ExecuteNonQuery();
                }
                catch
                {
                    Console.Write($" Не удалось создать таблицу '{o}'");
                }
            }
        }


        public void RelationTables(MySqlCommand command, SQLTemplates sql, IProgress<ProgressIndicate> progress, CancellationToken token)
        {
            var lists = new List<string>();
            lists.Add(sql.RelationIndex_Акт_АктПозиция());
            lists.Add(sql.RelationIndex_Акт_АктСтрока());
            lists.Add(sql.RelationIndex_Город_Клиент());
            lists.Add(sql.RelationIndex_ГруппаНоменклатура_ГруппаПрайслистНоменклатура());
            lists.Add(sql.RelationIndex_Декларант_ЭП());
            lists.Add(sql.RelationIndex_Дилер_Типдоговора());
            lists.Add(sql.RelationIndex_Договор_Баланс());
            lists.Add(sql.RelationIndex_Договор_Договор_Прайслист());
            lists.Add(sql.RelationIndex_Договор_Договор_Скидка());
            lists.Add(sql.RelationIndex_Договор_Журналзадолженности());
            lists.Add(sql.RelationIndex_Договор_ПакетДоговор());
            lists.Add(sql.RelationIndex_Договор_Продажа());
            lists.Add(sql.RelationIndex_Договор_РеестрПРОДоговор());
            lists.Add(sql.RelationIndex_Договор_ТоварАО());
            lists.Add(sql.RelationIndex_Договор_УчетныеданныеЭД2());
            lists.Add(sql.RelationIndex_Договор_ЭП());
            lists.Add(sql.RelationIndex_Должность_Персонал());
            lists.Add(sql.RelationIndex_Заявка_ЗаявкаЭП());
            lists.Add(sql.RelationIndex_Категория_Номенклатура());
            lists.Add(sql.RelationIndex_Клиент_Баланс());
            lists.Add(sql.RelationIndex_Клиент_Диадок());
            lists.Add(sql.RelationIndex_Клиент_Дилер());
            lists.Add(sql.RelationIndex_Клиент_Договор());
            lists.Add(sql.RelationIndex_Клиент_Журналзадолженности());
            lists.Add(sql.RelationIndex_Клиент_Журналработы());
            lists.Add(sql.RelationIndex_Клиент_Журналсообщений());
            lists.Add(sql.RelationIndex_Клиент_ПакетДоговор());
            lists.Add(sql.RelationIndex_Клиент_ПакетДоговорОбслуживание());
            lists.Add(sql.RelationIndex_Клиент_Плательщик());
            lists.Add(sql.RelationIndex_Клиент_Плательщик_Клиент());
            lists.Add(sql.RelationIndex_Клиент_Поставщик());
            lists.Add(sql.RelationIndex_Клиент_Продажа());
            lists.Add(sql.RelationIndex_Клиент_РеестрПРО());
            lists.Add(sql.RelationIndex_Клиент_Реквизит());
            lists.Add(sql.RelationIndex_Клиент_ТоварАО());
            lists.Add(sql.RelationIndex_Клиент_УчетныеданныеЭД2());
            lists.Add(sql.RelationIndex_Клиент_ЭП());
            lists.Add(sql.RelationIndex_Номенклатура_Пакет());
            lists.Add(sql.RelationIndex_Номенклатура_Пакет_Номенклатура());
            lists.Add(sql.RelationIndex_Номенклатура_ПакетДоговорОбслуживание());
            lists.Add(sql.RelationIndex_Номенклатура_Прайслист_Номенклатура());
            lists.Add(sql.RelationIndex_Номенклатура_ТоварАО());
            lists.Add(sql.RelationIndex_ОПФ_Клиент());
            lists.Add(sql.RelationIndex_Пакет_Пакет_Номенклатура());
            lists.Add(sql.RelationIndex_Пакет_ПакетДоговор());
            lists.Add(sql.RelationIndex_Пакет_ПакетДоговорСкидка());
            lists.Add(sql.RelationIndex_ПакетДоговор_ПакетДоговорЖурнал());
            lists.Add(sql.RelationIndex_ПакетДоговор_ПакетДоговорОбслуживание());
            lists.Add(sql.RelationIndex_Период_ПакетДоговорОбслуживание());
            lists.Add(sql.RelationIndex_Период_Позиция());
            lists.Add(sql.RelationIndex_Период_ТоварАОПериод());
            lists.Add(sql.RelationIndex_Плательщик_Договор());
            lists.Add(sql.RelationIndex_Плательщик_Плательщик_Клиент());
            lists.Add(sql.RelationIndex_Позиция_АктПозиция());
            lists.Add(sql.RelationIndex_Позиция_Позиция_Скидка());
            lists.Add(sql.RelationIndex_Позиция_Строка());
            lists.Add(sql.RelationIndex_Позиция_СчетПозиция());
            lists.Add(sql.RelationIndex_Позиция_ТоварАО());
            lists.Add(sql.RelationIndex_Позиция_ТоварАОПериод());
            lists.Add(sql.RelationIndex_Пользователь_Журналработы());
            lists.Add(sql.RelationIndex_Поставщик_Заявка());
            lists.Add(sql.RelationIndex_Поставщик_Персонал());
            lists.Add(sql.RelationIndex_Поставщик_Типдоговора());
            lists.Add(sql.RelationIndex_Прайслист_Договор_Прайслист());
            lists.Add(sql.RelationIndex_Прайслист_Прайслист_Номенклатура());
            lists.Add(sql.RelationIndex_Прайслист_Номенклатура_ГруппаПрайслистНоменклатура());
            lists.Add(sql.RelationIndex_Прайслист_Номенклатура_Позиция());
            lists.Add(sql.RelationIndex_Признакклиента_Клиент());
            lists.Add(sql.RelationIndex_Примечания_Баланс());
            lists.Add(sql.RelationIndex_Примечания_Дилер());
            lists.Add(sql.RelationIndex_Примечания_Договор());
            lists.Add(sql.RelationIndex_Примечания_Должность());
            lists.Add(sql.RelationIndex_Примечания_Журналзадолженности());
            lists.Add(sql.RelationIndex_Примечания_Журналработы());
            lists.Add(sql.RelationIndex_Примечания_Журналсообщений());
            lists.Add(sql.RelationIndex_Примечания_Журналстатистики());
            lists.Add(sql.RelationIndex_Примечания_Клиент());
            lists.Add(sql.RelationIndex_Примечания_Номенклатура());
            lists.Add(sql.RelationIndex_Примечания_ПакетДоговор());
            lists.Add(sql.RelationIndex_Примечания_Плательщик());
            lists.Add(sql.RelationIndex_Примечания_Пользователь());
            lists.Add(sql.RelationIndex_Примечания_Поставщик());
            lists.Add(sql.RelationIndex_Примечания_Реквизит());
            lists.Add(sql.RelationIndex_Примечания_Роль());
            lists.Add(sql.RelationIndex_Примечания_ТоварАО());
            lists.Add(sql.RelationIndex_Примечания_ТоварАОСтатус());
            lists.Add(sql.RelationIndex_Примечания_ЭП());
            lists.Add(sql.RelationIndex_Продажа_Акт());
            lists.Add(sql.RelationIndex_Продажа_Позиция());
            lists.Add(sql.RelationIndex_Продажа_Счет());
            lists.Add(sql.RelationIndex_Раздел_Договор());
            lists.Add(sql.RelationIndex_Раздел_Прайслист());
            lists.Add(sql.RelationIndex_Регион_Город());
            lists.Add(sql.RelationIndex_РеестрПРО_Баланс());
            lists.Add(sql.RelationIndex_РеестрПРО_РеестрПРОДоговор());
            lists.Add(sql.RelationIndex_Роль_Пользователь());
            lists.Add(sql.RelationIndex_Скидка_Договор_Скидка());
            lists.Add(sql.RelationIndex_Скидка_ПакетДоговорСкидка());
            lists.Add(sql.RelationIndex_Скидка_Позиция_Скидка());
            lists.Add(sql.RelationIndex_Скидка_Цена());
            lists.Add(sql.RelationIndex_Строка_АктСтрока());
            lists.Add(sql.RelationIndex_Строка_СчетСтрока());
            lists.Add(sql.RelationIndex_Счет_СчетПозиция());
            lists.Add(sql.RelationIndex_Счет_СчетСтрока());
            lists.Add(sql.RelationIndex_Таблицы_Примечания());
            lists.Add(sql.RelationIndex_Типдоговора_Договор());
            lists.Add(sql.RelationIndex_Типединицы_Номенклатура());
            lists.Add(sql.RelationIndex_Типединицы_Строка());
            lists.Add(sql.RelationIndex_Типзаявки_Заявка());
            lists.Add(sql.RelationIndex_Типотправкидокумента_Договор());
            lists.Add(sql.RelationIndex_ТипПРО_РеестрПРО());
            lists.Add(sql.RelationIndex_Типреквизита_Реквизит());
            lists.Add(sql.RelationIndex_Типскидки_Скидка());
            lists.Add(sql.RelationIndex_Типсобытияпакета_ПакетДоговорЖурнал());
            lists.Add(sql.RelationIndex_ТипстатусаАО_ТоварАОСтатус());
            lists.Add(sql.RelationIndex_Типцены_Цена());
            lists.Add(sql.RelationIndex_ТипЭД2_УчетныеданныеЭД2());
            lists.Add(sql.RelationIndex_ТоварАО_ТоварАОПериод());
            lists.Add(sql.RelationIndex_ТоварАО_ТоварАОСтатус());
            lists.Add(sql.RelationIndex_Цена_Пакет());
            lists.Add(sql.RelationIndex_Цена_Прайслист_Номенклатура());
            lists.Add(sql.RelationIndex_Цена_ТоварАО());
            lists.Add(sql.RelationIndex_ЭП_ЗаявкаЭП());
            int i = 0;
            int total = lists.Count;
            ProgressIndicate p = new ProgressIndicate();
            foreach (string o in lists)
            {
                try
                {
                    if (token.IsCancellationRequested)
                    {
                        return;
                    }
                    command.CommandText = o; command.ExecuteNonQuery();
                    if (progress != null)
                    {
                        p.current = i;
                        p.count = total;
                        progress.Report(p);
                    }
                    i++;
                }
                catch
                {
                    Console.Write($" Не удалось создать таблицу '{o}'");
                }
            }
        }

    }
}
