# WYCHaochan-Password-Generator

![Version](https://img.shields.io/github/v/release/WYCHaochan/WYCHaochan-Password-Generator?style=flat-square)
![License](https://img.shields.io/github/license/WYCHaochan/WYCHaochan-Password-Generator?style=flat-square)
![Platform](https://img.shields.io/badge/platform-Windows-blue?style=flat-square)
![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=flat-square)
![Stars](https://img.shields.io/github/stars/WYCHaochan/WYCHaochan-Password-Generator?style=flat-square)
![Last Commit](https://img.shields.io/github/last-commit/WYCHaochan/WYCHaochan-Password-Generator?style=flat-square)

**皓叶草密码生成器**

一个基于 **C#** 和 **.NET 8** 开发的 Windows 控制台密码生成器。

本项目旨在帮助用户快速生成随机密码，用于网站、应用程序及各类账户的密码设置。

程序使用 .NET `System.Security.Cryptography` 提供的密码学安全随机数生成器（CSPRNG）生成随机字符，并对生成结果进行规则检查，以确保密码满足用户选择的基本组成要求。

---

## ✨ 功能

- 自定义密码长度
  - 支持 **4～96 位**
  - 默认 **8 位**
- 支持数字
- 支持大写字母
- 支持小写字母
- 可选特殊字符
- 支持一次生成多个密码
  - 支持 **1～32 个**
- 自动检查密码组成
  - 大写字母
  - 小写字母
  - 数字
  - 特殊字符（启用时）
- 使用密码学安全随机数生成器（CSPRNG）
- 无需网络连接即可运行
- 免费开源

---

## 🔐 密码生成

程序使用：

```csharp
RandomNumberGenerator.GetInt32()
```

生成随机字符索引，而不是使用普通的 `System.Random`。

生成密码后，程序会检查密码是否同时包含所要求的字符类型。

例如启用特殊字符时，密码必须同时包含：

* 至少一个大写字母
* 至少一个小写字母
* 至少一个数字
* 至少一个特殊字符

如果生成的密码不符合要求，程序会自动重新生成，直到满足条件。

### 默认字符集

**字母：**

```text
ABCDEFGHIJKLMNOPQRSTUVWXYZ
abcdefghijklmnopqrstuvwxyz
```

**数字：**

```text
0123456789
```

**特殊字符：**

```text
@#$%&*!
```

---

## 💻 使用方法

运行程序后，首先会显示免责声明。

阅读免责声明后，输入 `Y` 或 `y` 并按回车键，即可继续使用。

之后按照程序提示设置：

1. 密码长度
2. 是否包含特殊字符
3. 生成密码的数量

程序会显示生成结果。

如果需要重新生成，可以选择继续生成。

---

## 📦 下载

可以前往 GitHub Releases 下载已经编译好的 Windows 版本：

**GitHub Releases**

> 当前版本：[v1.0.0](https://github.com/WYCHaochan/WYCHaochan-Password-Generator/releases/latest)

您也可以自行克隆代码后使用 .NET 8 编译项目。

---

## 🛠️ 开发环境

* **C#**
* **.NET 8**
* **Visual Studio 2022**
* **Windows**

---

## 🌐 项目特点

### 无需联网

本程序生成密码时无需访问网络，也不会主动将生成的密码上传至网络服务器。

密码生成过程在本地完成。

### 开源

项目源代码公开，任何人都可以查看程序的实现方式，并根据 MIT License 的规定使用、修改和分发本项目。

---

## ⚠️ 免责声明

本程序使用密码学安全随机数生成器生成密码，但任何软件都无法保证生成的密码在所有情况下绝对安全。

在有限的随机空间中，不同时间生成相同密码在理论上仍然可能发生。密码长度越长，其可能的组合数量越大，因此随机生成相同密码的概率通常越低。

本程序不会主动将生成的密码上传至网络，但密码安全仍可能受到操作系统、设备、恶意软件、剪贴板以及实际使用环境等因素影响。

请妥善保管生成的密码。

因密码丢失、泄露或因用户自身原因造成的其他损失，本项目及其开发者不承担责任。

请勿将生成的密码直接公开、发送给他人或提交至不可信的网站。

---

## 📄 开源协议

本项目采用 **MIT License** 开源。

详细内容请参阅项目中的 [`LICENSE`](LICENSE) 文件。

---

## 👤 作者

**皓叶草（WYCHaochan）**

GitHub：

[https://github.com/WYCHaochan](https://github.com/WYCHaochan)

---

## 📌 项目状态

当前版本：

**v1.0.0**

这是本项目的首个正式版本。

后续版本可能会加入更多密码生成选项、特殊字符模式、快速生成模式、高级配置以及密码保存等功能。

---

> 如果这个小工具对你有所帮助，欢迎 Star ⭐ 本项目。
