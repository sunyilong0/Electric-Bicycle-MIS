

**如果喜欢本项目，可以点个小心心~**

项目由孙逸龙独立完成，已经独立申请软件著作权，仍有部分不够完善，希望可以一同改进！
文档存在省略，若需要完整版文档与数据库————请联系邮箱yl.sun0@qq.com。

# 基于Smobiler的校园电动车管理信息系统手机APP
# 摘要

最新数据显示，目前海南省电动自行车保有量约为300万辆，且呈逐年上涨趋势。最新的2021年人口统计显示，海南省常住人口1008.12万人，这样计算下来，平均三人中就有一辆电动车。而对于海南大学海甸校区校内，更存在电动车管理混乱，宿舍楼宇之间数据孤岛等问题。

本文根据需求分析，基于Smobiler平台与C\#语言开发出了一款“校园电动车管理信息系统”的手机APP。系统使用Visual Studio进行编写与调试并且利用PowerDesigner16.5对于数据库进行设计与建立。

在功能实现方面，针对用户端与管理员端，程序实现了登记车辆信息、修改车辆信息、查询车辆信息、留言等多种功能。此外为了防止不能及时联系上该同学，系统能够智能显示同宿舍同学的联系方式，便于管理者能够及时有效联系到车主。

虽然信息化的普及，但是校内较多基层人员对于电子产品使用存在学习壁垒，本文在对系统进行分析与设计的时候着重考虑到了系统的操作简易性。


# 系统概述

本章解释了研究本系统实现的原因并分析了电动车管理信息系统的主要功能及业务人员的需求，确立的系统的功能结构及系统的开发环境，同时也对软件系统的结构加以论述。为了精确需求，本文就海南大学为例进行相关调研分析。

## 背景简介与当前现状

数据显示，目前海南省电动自行车保有量约为300万辆，且呈逐年上涨趋势[1]。最新的2021年人口统计显示，海南省常住人口1008.12万人，这样计算下来，平均三人中就有一辆电动车。根据对海口市区的龙昆南、白龙南、人民路等交通路口观察可以发现，绝大部分时候电动车的数量是绝对多于步行行人数量的。

![](media/93be1f530cbb14d43ca26f6d6730f60b.png)

图 1 海口骑楼红绿灯过马路图片

在海南大学内（简称校内）虽然暂未有保有量数据，但是每逢上下课高峰期经常会出现“电动车堵车潮”，晚上10点后宿舍楼下电动车乱停乱放的电动车拥堵现象。根据对校内楼管、保卫处的访谈后发现，目前校内对于庞大数量的电动车管理虽然有“发放车牌”“登记信息”等方法，但总体仍然处于“手工管理”阶段。查阅相关资料会发现，在车辆管理中对于“汽车”与“摩托车”的研究较为多，但是鲜有对于“电动自行车”的相关研究需求研究与信息系统的分析与设计。

![](media/9801908c0d448b8f8ce51498067322ce.png)

图 2 四教旁电动车停放图片



#  系统分析


![](media/f75aed4a16ab5fd83c4d8a0ae1a6c719.png)

图 9 访谈存在问题分析

## 需求分析

### 系统用户

表格 1 系统用户角色与类型

| 序号 | 角色         | 用户类型 |
|------|--------------|----------|
| 1    | 电动车车主   | 用户     |
| 2    | 保卫处、楼管 | 管理员   |


注：楼管与保卫处人员的操作界面需要极其简单易懂，切勿复杂

### 功能描述

#### 平台的电动车管理系统用户端实现功能:

1.  登录功能:学员根据学号和密码登录个人账户。

2.  登记个人电动车车辆信息功能：用于登记电动车车辆信息。

3.  查看个人电动车辆信息功能:用户可以查看个人车辆信息。

4.  更新个人电动车车辆信息功能：用户转卖、遗失车辆、后进行操作。
...

#### 平台的电动车管理系统管理员端实现功能: 

...

### 用例模型

#### 用户端



1.  用例描述

表格 2 登录功能用例描述

| 名称               | 登录功能                                                                                                                      |
|--------------------|-------------------------------------------------------------------------------------------------------------------------------|
| 参与者/角色        | 用户                                                                                                                          |
| 前置条件           | 打开登录页面                                                                                                                  |
| 后置条件           | 进入用户页面首页                                                                                                              |
| 主事件流           |                                                                                                                               |
| 参与者行为         | 系统行为                                                                                                                      |
| 用户输入学号与密码 |  验证用户名与密码 验证信息成功，跳转用户页面                                                                                  |
| 备选事件流         | 3a.系统验证登录失败 系统提示用户名或密码有误 用户重新输入用户名或密码，转到步骤l。 超过3次输错密码，转到步骤l，启用验证码登录 |

表格 3 登记个人电动车信息用例描述

| 名称                                             | 登记个人电动车信息                                                     |
|--------------------------------------------------|------------------------------------------------------------------------|
| 参与者/角色                                      | 用户                                                                   |
| 前置条件                                         | 进入用户首页                                                           |
| 后置条件                                         | 返回用户首页                                                           |
| 主事件流                                         |                                                                        |
| 参与者行为                                       | 系统行为                                                               |
| 1.用户点击登记信息按钮  3.用户输入电动车相关信息 |  2.系统出现登记信息表单  4.检查信息并提交审核至管理员处 5.跳转用户页面 |
| 备选事件流                                       | 4a.登记信息不完备 系统提示登记信息不完备 用户继续补充输入登记信息。    |

表格 4 查看个人电动车信息用例描述

| 名称                        | 查看个人电动车信息                                                     |
|-----------------------------|------------------------------------------------------------------------|
| 参与者/角色                 | 用户                                                                   |
| 前置条件                    | 进入用户首页                                                           |
| 后置条件                    | 进入个人信息页                                                         |
| 主事件流                    |                                                                        |
| 参与者行为                  | 系统行为                                                               |
| 1.用户点击查看个人信息按钮  |  2.系统出现个人信息表(包含更新信息与返回主页按钮)                      |
| 备选事件流                  | 2a.未登记个人信息 系统提示该用户未登记个人信息 用户继续补充输入信息。  |

表格 5 更新个人电动车信息用例描述
.....

表格 6 查看他人电动车信息用例描述

.....

表格 7 向他人电动车车辆留言功能用例描述

.....

表格 8 查看留言功能用例描述

.....

表格 9 注销功能用例描述
.....

#### 管理员端

1.  用例图

图 11 管理员用例图

1.  用例说明

表格 10 登录功能用例描述

| 名称                   | 登录功能                                                                                                                      |
|------------------------|-------------------------------------------------------------------------------------------------------------------------------|
| 参与者/角色            | 管理员                                                                                                                        |
| 前置条件               | 打开登录页面                                                                                                                  |
| 后置条件               | 进入管理员页面首页                                                                                                            |
| 主事件流               |                                                                                                                               |
| 参与者行为             | 系统行为                                                                                                                      |
| 1.管理员输入工号与密码 |  2.验证用户名与密码 3.验证信息成功，跳转管理员页面                                                                            |
| 备选事件流             | 3a.系统验证登录失败 系统提示用户名或密码有误 用户重新输入用户名或密码，转到步骤l。 超过3次输错密码，转到步骤l，启用验证码登录 |

表格 11 查看用户电动车辆信息功能用例描述

.....

表格 12 审核信息功能用例描述

.....

表格 13 注销功能用例描述
.....

## 信息数据库表格

本节主要展示了所有需要获取的信息与数据，由于访谈还在进行中，故会有不完善的成分。

表格 14 信息数据库表

| **信息名称** | **信息来源** | **是否必填** | **是否可修改** | **\<用户\>登记个人电动车车辆信息** | **\<用户\>查看他人电动车车辆信息** | **\<管理员\>查看电动车信息** |
|--------------|--------------|--------------|----------------|------------------------------------|------------------------------------|------------------------------|
| 学号         | 校内数据库   |              | 否             |                                    |                                    |                              |
| 姓名         | 校内数据库   |              | 否             |                                    |  （只显示姓）                      |                              |
| 班级         | 校内数据库   |              | 否             |                                    |                                    |                              |
| 宿舍号       | 校内数据库   |              | 否             |                                    |                                    |                              |
| 车辆登记号   | 楼管发放     |              | 是             |                                    |                                    |                              |
| 车架号       | 车辆自带     |              | 是             |                                    |                                    |                              |
| 车牌号       |              | 否           | 是             |                                    |                                    |                              |
| 车辆照片     | 用户提供     |              | 是             |                                    |                                    |                              |
| 电话         | 用户提供     |              | 是             |                                    |  （只显示开头四位）                |                              |
| 邮件         | 用户提供     |              | 是             |                                    |                                    |                              |

## 本章小结

本章由单人通过调研完成，耗时较大，但是对校内当前面临的问题挑战有了充分的了解。这些信息与在调研前所思所想有着巨大的不同，收获巨大。同时主要介绍了系统需求分析,确定了用户需求和系统功能。制作了用户端与管理员端的用例图，根据用例图对用户端与管理员端的每一个功能进行了详细的用例规约描述。系统分析人员可通过对用例图与用例规约专业术语的表达来明确系统的需求，.....

# 第三章 系统设计

## 开发环境

### 硬件

>   华为 NBLK-WAX9X笔记本电脑一台

-   CPU：AMD Ryzen 5 3500U with Radeon Vega Gfx 四核笔记本处理器

-   ROM：8.00 GB ROM DDR4 2667MHz

-   GPU：AMD Radeon Vega 8 Graphics

-   硬盘：三星 MZVLB512HAJQ-00000

### 软件

-   操作系统: Windows 10 家庭中文版V.20H2、Android 10系统与华为鸿蒙2.0系统

-   开发工具: Visual Studio2017、Visio2018、PowerDesigner16.5、Microsoft SQL
    Server Management Studio、Mathpix Snipping Tool等

-   数据库: SQL Server express

## 技术介绍

### Smobiler-.Net移动开发平台

Smobiler-.Net移动开发平台由四个部分组成：SmobilerDesigner，SmobilerClient，云平台在线打包，Smobiler应用市场[4]。

SmobilerDesigner通过实现.NET的component组件方式，借助Visual
Studio集成开发环境来开发移动应用。SmobilerClient是通用的框架调试工具，使用自有的stml协议实现调试工具的原生控件渲染和事件。云平台在线打包支持打造属于自己的一款个性app，她可以自定义应用图标、欢迎页等的设置并在云端生成Android和IOS安装文件；同时.....

![https://www.smobiler.com/images/guide/introduction/1.png](media/233308a247d494dc4a1b9040435eb6ff.png)

图 12 Smobiler整体机制

### 基于React Native前端技术

.....

![D:\\Desktop\\QQ拼音截图20210629000205.png](media/c64eefca5c1cca0c20da552140d8dca9.png)

图 13 React特点

### PowerDesigner数据库设计软件

.....

## 数据库设计

根据需求分析与范式规则，本文对系统的数据库进行构建。

-   用户与车辆是一对多的关系，一个人可以拥有多辆车，而一辆车只能被一个人拥有。

-   车辆与留言是一对多的关系，一辆车能有多个留言，而一个留言只能对应一辆车。
.....

![](media/84181b71086dcc2ec75617a5d01aa309.png)

图 14 数据库概念模型设计（中文）

在数据库的物理模型中，用户可以作为车辆表与被等待车辆表的外键，而车辆的登记ID主键能作为消息表与进出表的外键。

.....

图 15数据库物理模型设计（英文）

.....

图 16 SQL数据库关系图

## 用户端与管理员端通用界面设计

### 用户登录与主页信息展示

在这一模块中用户在登录页面进行登录，并且可以使用记录密码来辨别。在后期会加入手势登录的多种登录方式，能够更加便捷的使用。登录成功之后会弹出登录成功的提示，窗口左上角点击按钮为侧边栏，能够展示个人的相应信息，以保证登录人员的正确性。查看本人车辆”按钮能够将本人所有的车辆都展示在自己面前。再点击下方“我的”按钮后，会显示出个人的相关信息，在此我们可以对个人的信息以及密码进行修改，并且可以有“退出登录”按钮。“

图 17 .....

![](media/6b6c1b8dc3584c87d9250fcceaa07f89.png)
![](media/1c580ac86e843db5f85fc569978ed39f.png)

图 18登录页面（左图）和登录成功页面（右图）

![](media/e9e6028dda145c1752d4196388744326.png)
![](media/595734b4e19e1a2ea1be6a0014f96222.png)

图 19 用户主页（左图）和侧边信息栏（右图）

![](media/96ad80fecbe0e5b793cf2c4261f2d888.png)
![](media/e2620332845a060fbda14fd19906b46a.png)

图 20 个人信息与退出登录页（左图）与本人车辆列表（右图）

![](media/3e45fedfd91149c5f624029e7913c764.png)
![](media/7994de6ae3fb6b1f710cafc0841a87a8.png)

图 21 更新密码（左图）与退出系统（右图）

### 登记与修改车辆信息

我们可以点击登记行车，从而能够登记新车按照规定填写必填的内容，并且点击提交后，.....
图 22登记与修改车辆信息序列图

![](media/ac79272cbb914e9153b3aee02a7eb160.png)
![](media/00c622f9f7a492cbeb2f175fb0809a98.png)

图 23 车辆信息登记页（左图）与图片选择栏（右图）


![](media/49ad441619e06b676a38ca8c752eea38.png)

图 24 模糊查询其他车辆（右图）

### 查询车辆信息与留言功能

点击“他人车辆”，可以.....

图 25 查询车辆信息与留言功能序列图

![](media/7efdd6ce52ecccd1998c6edcabd29980.png)
![](media/9b8c3977a067838530e4bb827f164ae9.png)

图 26成功模糊查询页面（左图）和留言页面（右图）

![](media/82edcd7d81f961e400a6813c47f244ab.png)
![](media/b403c8075953ece68a5b3ac6a044938d.png)

图 27 用户主页无法打开“所有信息”提示（左图）与留言板展示（右图）

## 管理员端专有页面设计

管理员账户登录后，可以对于车辆进行。最完整的查找，并且.....



![](media/c776ba598dc8f268a24deb78d29b879c.png)
![](media/e64d8811e4a39989b4b9b17fd06fbe69.png)
![](media/e6e9ef4249b7da2509d6e378f3299570.png)

图 29
管理员主页（左图）、查询所有信息页面（中图）和“电话联系”按钮自动跳转（右图）

# 第四章 系统实施

## 工程概况

本系统主要在windows10环境的Visual Studio2017、Android系统与华为鸿蒙系统下进行开发。在Visual
Studio2017下工程名叫“电动车管理系统V2.0”。项目内除系统文件外包含...

![](media/df3028c0fa711cbb0471279a92a1f254.png)

图 30项目展示

### Admin文件夹

Admin文件夹内主要由.....

![](media/01dd16e2d404cf58210711f037e7d323.png)![](media/29872a509fd816239dd43e3b6706cff7.png)

图 31 项目文件夹展示

### Contral文件夹

文件夹包括控制控件等多种控件。其中包含侧边栏Cebianlan.cs、.....

### User文件夹

略
### Frmclass文件夹

略

## 部分代码实现

### 登录界面按钮

>   登录按钮中考虑考虑到了密码错误与记住密码密码等操作。
略

### 数据库连接语句

先对文本框内容进行监测，保证不会出现其他错误，再用SqlDataAdapter对内容进行获取。

### 系统回退键代码编写



### Sql类的连接语句


### 主页选择按钮代码


### 保存图片代码


### 全局变量代码


### 截取前N位string字符方法


### 拨打电话与发送短信按钮





# 目前不足与未来方向

### 完善操作处理方式
略

### 完善界面

略
### 增加功能
略

### 物联网应用

略


# 参考文献

>   [1]黄炜钢.基于移动端的中职学生宿舍管理系统的设计与实现[J].信息与电脑(理论版),2021,33(02):141-144.

>   [2]周坤泰. 海南省消费市场监管思路研究[D].海南大学,2019.

>   [3]韩炜,杨俊,陈逢文,张玉利,邓渝.创业企业如何构建联结组合提升绩效?——基于“结构—资源”互动过程的案例研究[J].管理世界,2017(10):130-149+188.

>   [4]朱勇.基于React
>   Native的移动办公应用开发实践[J].中国金融电脑,2017(04):56-60.

>   [5]肖静华,谢康,吴瑶,冉佳森.企业与消费者协同演化动态能力构建:B2C电商梦芭莎案例研究[J].管理世界,2014(08):134-151+179.

>   [6]张郑军.基于PowerDesigner数据建模研究与实践[J].山西煤炭管理干部学院学报,2013,26(04):126-128.

>   [7]杨蔚鸣.PowerDesigner在《数据库原理》实践教学中的应用[J].电脑知识与技术,2009,5(27):7723-7724.

