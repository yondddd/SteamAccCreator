
# 运行前置条件
> 基于Steam-Account-Generator改写，地址 https://github.com/EarsKilla/Steam-Account-Generator/releases
Steam-Account-Generator邮件激活模块不支持126、google第三方邮件激活。邮件激活模块单独另一脚本适配。

1. 已经加载代理Ip池,代理格式，建立文件D:/steam/Steam-Account-Generator/proxy_list.txt,文件顶部不留空行,代理池大小根据每次注册邮箱数量决定  

```
http://58.220.95.90:9401
https://58.220.95.90:9401
socks4://127.0.0.1:8888
socks5://127.0.0.1:8888
```

2. 已经选择验证码解决方式为打码平台接入(RuCaptcha)
添加API_Key""


3. 建立文件D:/steam/Steam-Account-Generator/waited_registe_mail.txt，待注册邮件，文件顶部不留空行，每次注册邮箱不超过100个,同类型邮箱批量注册，格式如下,
```
Alynna5387@163.com
Vinessa6050@163.com
```

4. 注册成功依据，控制面板显示saving file .....,表示steam邮件发送成功。随后一小时内执行另一邮件激活脚本steam_account_activation，即完成注册流程