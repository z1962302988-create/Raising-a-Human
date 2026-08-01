# 饲养一只人类 / Raising a Human

一款计划使用 Unity 开发的治愈系房间装修与叙事游戏：玩家扮演刚取得资格的猫咪，通过共居、观察与布置空间，帮助一名“停止生活”的人类重新获得选择生活的能力。

## 目录

- `Docs/Worldbuilding/`：策划可读的世界观与角色设定
- `Docs/Quests/`：按天整理的任务流程与实现规格
- `Docs/Worldbuilding/Source/`：原始 Word 文档，只作来源存档
- `Assets/StreamingAssets/Lore/`：Unity 运行时可读取的 JSON 设定数据
- `Assets/StreamingAssets/Quests/`：Unity 运行时可读取的任务数据
- `Assets/Scripts/Lore/`：JSON 数据模型与加载器
- `Assets/Scripts/Quests/`：任务数据模型与加载器

## Unity 接入

建议用 Unity Hub 在本目录创建或打开项目。现有文件都位于 Unity 约定目录中，不绑定具体 Unity 版本。

运行时读取示例：

```csharp
WorldLore world = LoreLoader.LoadWorld();
HumanProfile human = LoreLoader.LoadHuman();
Debug.Log(world.city.name);       // 软垫城
Debug.Log(human.identity.id);     // H-071
```

> 当前 JSON 使用 `StreamingAssets`，适合早期原型。正式制作对白、本地化和任务系统时，建议将展示文本迁移到 Unity Localization，稳定配置迁移为 ScriptableObject。
