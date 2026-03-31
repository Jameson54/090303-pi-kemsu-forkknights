using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForkKnights.Group1 {
  internal class Chernenko : IKnight {
    public int healthPoints;
    public string name;
    public string specialization { get; set; }
    public int manaPoints;
    public int damage;
    public int age;
    public string weapon { get; set; }
    public string element { get; set; }

    public Chernenko() {
      healthPoints = 120;
      name = "Северный Вихрь";
      specialization = "Друид Севера";
      manaPoints = 200;
      damage = 55;
      age = 847;
      weapon = "Посох Ледяного Древа";
      element = "Лёд и Ветер";
    }

    public string GetJobApplication() {
      string jobAnnouncement;

      jobAnnouncement = "❄️ Здравствуй, странник! Это ты ищешь защитника для своего каравана? ❄️\n" +
          $"Я {specialization}, хранитель древних лесов и повелитель стихий. Имя мне {name}.\n" +
          $"Мне уже {age} зим, но я полон сил и мудрости. В моём арсенале {weapon}, а моя стихия — {element}.\n" +
          $"Мои характеристики: ❤️ Здоровье: {healthPoints} | 💙 Мана: {manaPoints} | ⚔️ Урон: {damage}\n" +
          "Я ищу работу наёмником или охранником. Могу заморозить любого врага, защитить ваш дом или просто составить компанию в дальнем путешествии.\n" +
          "К моим услугам: лечение травами, контроль погоды и немного древней магии. Плата договорная, но прошу не золотом, а семенами редких растений.\n" +
          "Позовите Северный Вихрь, и я приду на помощь, пока не растаял последний снег! 🌨️";

      return jobAnnouncement;
    }
  }
}
