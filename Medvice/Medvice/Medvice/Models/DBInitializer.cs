using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Medvice.Models
{
    public class DBInitializer : DropCreateDatabaseAlways<MedviceContext>
    {
        protected override void Seed(MedviceContext context)
        {
            context.Diseases.Add(new Disease { DiseaseId = "1", Name = "ОРВИ", Description = "НАХУЯ ЛЕЧИТЬСЯ, ЕБОШ ПИВАС" });
            context.SaveChanges();
            context.Simpotoms.Add(new Simpotom { SimpotomId = "1", Name = "Температура", Content = "Температура тела выше 37" });
            context.SaveChanges();
            context.Diseases.Where(x => x.DiseaseId == "1").First().Simpotoms.Add(context.Simpotoms.Where(x => x.SimpotomId == "1").First());
            context.SaveChanges();
            base.Seed(context);
        }

        public static void Create(MedviceContext context)
        {
            context.Database.Delete();
            context.Diseases.Add(new Disease { DiseaseId = "1", Name = "ОРВИ", Description = "Отличительным признаком ОРВИ является начало заболевания с его локальных проявлений. Поэтому симптомы ОРВИ могут включать насморк, осиплость голоса, «першение» в горле, сухой кашель." });
            context.SaveChanges();
            context.Simpotoms.Add(new Simpotom { SimpotomId = "1", Name = "Температура", Content = "Температура тела выше 37" });
            context.SaveChanges();
            context.Diseases.Where(x => x.DiseaseId == "1").First().Simpotoms.Add(context.Simpotoms.Where(x => x.SimpotomId == "1").First());
            context.SaveChanges();
            //~~~~~~~~~~~~~~~~~~~~~~~~
            context.Diseases.Add(new Disease { DiseaseId = "2", Name = "Мигрень", Description = "Главные симптомы мигрени – это внезапное появление интенсивной пульсирующей головной боли, которая часто распространяется на область глаз, височную и скуловую области и может сопровождаться тошнотой и рвотой. Приступы мигрени могут длиться от нескольких часов до нескольких дней." });
            context.SaveChanges();
            context.Simpotoms.Add(new Simpotom { SimpotomId = "2", Name = "Головные боли", Content = "Кластерные боли, напряжения" });
            context.SaveChanges();
            context.Diseases.Where(x => x.DiseaseId == "2").First().Simpotoms.Add(context.Simpotoms.Where(x => x.SimpotomId == "2").First());
            context.SaveChanges();
            //~~~~~~~~~~~~~~~~~~~~~~~~
            context.Diseases.Add(new Disease { DiseaseId = "3", Name = "Ринит", Description = "Для облегчения симптомов следует избегать таких раздражителей как резкое изменение температуры и сигаретный дым. Необходимо пить больше жидкости и использовать увлажнитель воздуха. Можно промывать полость носа и полоскать рот изотоническими солевыми растворами." });
            context.SaveChanges();
            context.Simpotoms.Add(new Simpotom { SimpotomId = "3", Name = "Заложенность носа", Content = "Заложенность носа приводит к затруднению носового дыхания. Заложенность носа может возникать как самостоятельный симптом, а может сопровождаться появлением повышенного отделяемого из носа, то есть насморком." });
            context.SaveChanges();
            context.Diseases.Where(x => x.DiseaseId == "3").First().Simpotoms.Add(context.Simpotoms.Where(x => x.SimpotomId == "3").First());
            context.Diseases.Where(x => x.DiseaseId == "1").First().Simpotoms.Add(context.Simpotoms.Where(x => x.SimpotomId == "3").First());
            context.SaveChanges();
            //~~~~~~~~~~~~~~~~~~~~~~~~
            context.Diseases.Add(new Disease { DiseaseId = "4", Name = "Вывих", Description = "Само пройдет, своевременно." });
            context.SaveChanges();
            context.Simpotoms.Add(new Simpotom { SimpotomId = "4", Name = "Миалгия", Content = "Мышечная боль может возникнуть в любом месте тела, но чаще всего она появляется в мышцах шеи, спины, ног и рук. В зависимости от причины боли в мышцах могут значительно отличаться по интенсивности и продолжительности." });
            context.SaveChanges();
            context.Simpotoms.Add(new Simpotom { SimpotomId = "5", Name = "Боль в суставах", Content = "Затруднительное перевдижение, сопровождаемое дискомфортом и болью." });
            context.SaveChanges();
            context.Diseases.Where(x => x.DiseaseId == "4").First().Simpotoms.Add(context.Simpotoms.Where(x => x.SimpotomId == "4").First());
            context.Diseases.Where(x => x.DiseaseId == "4").First().Simpotoms.Add(context.Simpotoms.Where(x => x.SimpotomId == "5").First());
            context.SaveChanges();
            //~~~~~~~~~~~~~~~~~~~~~~~~
            context.Diseases.Add(new Disease { DiseaseId = "5", Name = "Растяжение", Description = "Само пройдет, долговато." });
            context.SaveChanges();
            context.Diseases.Where(x => x.DiseaseId == "5").First().Simpotoms.Add(context.Simpotoms.Where(x => x.SimpotomId == "5").First());
            context.SaveChanges();
            //~~~~~~~~~~~~~~~~~~~~~~~~
            context.Diseases.Add(new Disease { DiseaseId = "6", Name = "Синусит", Description = "Симптомы синусита - это затруднение носового дыхания, попеременная заложенность правой или левой ноздри, длительный насморк с водянистыми, слизистыми или гнойными выделениями. Происходит снижение обоняния. По утрам отмечается обильное отхаркивание выделений, которые стекали в глотку за ночь. Возможны такие симптомы синусита, как головная боль, чувство тяжести в области пораженных пазух, слезотечение, светобоязнь, потеря аппетита, нарушение сна, появление отечности век и щек." });
            context.SaveChanges();
            context.Simpotoms.Add(new Simpotom { SimpotomId = "6", Name = "Насморк", Content = "Насморком называют избыточное отделяемое из носа, которое может варьироваться от прозрачной жидкости до густой слизи, продуцируемых слизистой носа и окружающих тканей. Отделяемое может удаляться через нос  или стекать по задней стенки глотки в полость рта." });
            context.SaveChanges();
            context.Diseases.Where(x => x.DiseaseId == "6").First().Simpotoms.Add(context.Simpotoms.Where(x => x.SimpotomId == "6").First());
            context.Diseases.Where(x => x.DiseaseId == "6").First().Simpotoms.Add(context.Simpotoms.Where(x => x.SimpotomId == "3").First());
            context.SaveChanges();
            //~~~~~~~~~~~~~~~~~~~~~~~~
            context.Simpotoms.Add(new Simpotom { SimpotomId = "7", Name = "Кашель", Content = "Кашель – это защитный механизм, с помощью которого организм реагирует на раздражители в горле и дыхательных путях. Раздражитель стимулирует нервные окончания, которые посылают сигналы в мозг. Мозг, в свою очередь, дает команду мышцам живота и грудной клетки создать сильный толчок воздуха для того, чтобы попытаться удалить раздражитель из дыхательных путей." });
            context.SaveChanges();
            context.Diseases.Add(new Disease { DiseaseId = "7", Name = "Бронхит", Description = "Хронический бронхит - это хроническое воспаление, развивающееся в бронхах, которое приводит к перестройке их слизистой оболочки, в результате чего нарушается её защитная и очистительная функции, а продукция слизи значительно возрастает, возрастает и вязкость слизи. В силу физиологических особенностей функционирования, бронхи расширяются при вдохе и несколько сужаются при выдохе." });
            context.SaveChanges();
            context.Diseases.Where(x => x.DiseaseId == "1").First().Simpotoms.Add(context.Simpotoms.Where(x => x.SimpotomId == "7").First());
            context.Diseases.Where(x => x.DiseaseId == "7").First().Simpotoms.Add(context.Simpotoms.Where(x => x.SimpotomId == "7").First());
            context.SaveChanges();
            //~~~~~~~~~~~~~~~~~~~~~~~~
            context.Diseases.Add(new Disease { DiseaseId = "8", Name = "Сердечная недостаточность", Description = "Легочное сердце (легочно-сердечная недостаточность) - это патологическое состояние, для которого характерно увеличение правого предсердия и правого желудочка в результате повышенного давления в легочном (малом) круге кровообращения. Причины развития данного состояния могут возникнуть остро (острое легочное сердце) или формироваться постепенно (хроническое легочное сердце). Причиной острых нарушений могут быть тромбоэмболия в системе легочных артерий, спадение легкого в результате образования патологических отверстий в плевре (пневмоторакс), затяжной приступ астмы, обширная пневмония." });
            context.SaveChanges();
            context.Simpotoms.Add(new Simpotom { SimpotomId = "8", Name = "Повышенная жажда", Content = "Жажда может возникнуть в ответ на повышение температуры тела или окружающей среды, а также на интенсивную физическую нагрузку, когда организм с потом теряет большое количество жидкости. Кроме того, повышенная жажда может быть вызвана употреблением в пищу острых и соленых продуктов, а также приемом некоторых лекарственных препаратов." });
            context.Simpotoms.Add(new Simpotom { SimpotomId = "9", Name = "Одышка", Content = "Одышка или диспноэ – это затруднение дыхания, при котором возникает нарушение его ритма или частоты и глубины. Это состояние сопровождается чувством нехватки воздуха и чувством тяжести или сжимания в грудной клетке." });
            context.SaveChanges();
            context.Diseases.Where(x => x.DiseaseId == "8").First().Simpotoms.Add(context.Simpotoms.Where(x => x.SimpotomId == "8").First());
            context.Diseases.Where(x => x.DiseaseId == "8").First().Simpotoms.Add(context.Simpotoms.Where(x => x.SimpotomId == "9").First());
            context.SaveChanges();
            //~~~~~~~~~~~~~~~~~~~~~~~~
            context.Diseases.Add(new Disease { DiseaseId = "9", Name = "Панкреатит", Description = "Острый панкреатит - это острое воспалительное заболевание поджелудочной железы, при котором ферменты, участвующие в расщеплении пищи, выбрасываются не в просвет кишки, а начинают разрушать саму железу (самопереваривание) - вплоть до полного её разрушения - панкреонекроза." });
            context.SaveChanges();
            context.Simpotoms.Add(new Simpotom { SimpotomId = "10", Name = "Тошнота", Content = "Тошнота и рвота являются симптомами, которые могут быть вызваны многими разнообразными причинами. Тошнота и рвота могут возникать как вместе, так и по отдельности." });
            context.Simpotoms.Add(new Simpotom { SimpotomId = "11", Name = "Рвота", Content = "Тошнота и рвота являются симптомами, которые могут быть вызваны многими разнообразными причинами. Тошнота и рвота могут возникать как вместе, так и по отдельности." });
            context.SaveChanges();
            context.Diseases.Where(x => x.DiseaseId == "9").First().Simpotoms.Add(context.Simpotoms.Where(x => x.SimpotomId == "10").First());
            context.Diseases.Where(x => x.DiseaseId == "9").First().Simpotoms.Add(context.Simpotoms.Where(x => x.SimpotomId == "11").First());
            context.SaveChanges();
            //~~~~~~~~~~~~~~~~~~~~~~~~
            context.Diseases.Add(new Disease { DiseaseId = "10", Name = "Анемия", Description = "Анемия – это клиническое состояние, обусловленное снижением содержания гемоглобина в крови ниже 110 г/л. Чаще всего оно сопровождается также снижением количества красных кровяных телец – эритроцитов. Степень снижения гемоглобина обычно определяет тяжесть клинических проявлений анемии." });
            context.SaveChanges();
            context.Simpotoms.Add(new Simpotom { SimpotomId = "12", Name = "Тахикардия", Content = "Тахикардия – это повышение частоты сердечных сокращений в покое. Нормальная частота сердечных сокращений взрослого человека в состоянии покоя находится в диапазоне от 60 до 100 в минуту. При тахикардии сердце бьётся чаще, чем 100 ударов в минуту." });
            context.SaveChanges();
            context.Diseases.Where(x => x.DiseaseId == "10").First().Simpotoms.Add(context.Simpotoms.Where(x => x.SimpotomId == "12").First());
            context.SaveChanges();
        }
    }
}