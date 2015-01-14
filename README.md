

字幕组追剧助手
=======

适用场景
----

 1. 喜欢从论坛下载美剧/韩剧等资源的同学
 2. 嫌每次需要自己打开页面看更新的同学

了解工作原理
------

 - 首先软件会读取 tvseries.xml 文件，看看你追了什么剧集
 - 根据你的设置，读取 sites.xml 文件里面的配置，让程序能够到达正确的页面
 - 获得页面上的所有可下载连接，对比你已经下好的，看看缺了什么
 - 告诉你缺了哪一集，然后加入迅雷下载中


----------


如何添加追剧列表（tvseries.xml）
--------
由于我还没得空写添加功能，所以先辛苦一下自己手动加啦

首先我们看一下追剧文件（tvseries.xml）

    `<?xml version="1.0" encoding="utf-8" standalone="yes"?>
    <NimitzDEV>
      <media>
        <name>卡特探员</name>
    	<sitechecker>ygdy</sitechecker>
    	<linkdata><![CDATA[20150107/47075]]></linkdata>
    	<path><![CDATA[E:\TV\]]></path>
      </media>
    </NimitzDEV>`

每一个追剧信息都包含在`<media>`标签之中
所以我们每要添加一个追剧，就重复一组`<media>`标签就行了

那么，里面的每个小标签又代表了什么呢？

`<name>`标签，他储存的是剧集的名字，要注意的是，**不能重复哦**

`<sitechecker>`标签，它储存了追剧资源网站的配置名称（后面会介绍）

`<linkdata>`标签，他储存了剧集页面链接的一部分（后面会介绍）

`<path>`标签，他储存了下载剧集的存放路径，前面的工作流程提到

> 获得页面上的所有可下载连接，对比你已经下好的，看看缺了什么

也就是说，这个储存路径的设置会影响检测的结果，你下载到哪里，你就应该设置为哪里，这样程序才能知道哪一集你下载了，哪一集你没有下载。

特别要注意的是 `<linkdata>` 和 `<path>` 标签里面的内容，要用
`<![CDATA[内容]]` 包裹起来。要不然遇到特殊符号软件会崩溃的

> 软件自带的 sites.xml 里面只有一个资源网站，现在示例一下如何添加这个网站的追剧


 1. 首先打开这个网站的剧集列表页面
[阳光电影欧美电视剧](http://www.ygdy8.net/html/tv/oumeitv/index.html "阳光欧美电视剧")
    
 2. 选择一部你要追的美剧，比如我选择了
 [特工卡特/卡特探员 第一季](http://www.ygdy8.net/html/tv/oumeitv/20150107/47075.html)
 
 3. 观察他的页面链接
http://www.ygdy8.net/html/tv/oumeitv/20150107/47075.html
	我们取其中的 `20150107/47075` 作为链接的一部分
	把这一部分放到 `<linkdata>` 标签之中
	
 4. 然后考虑下这个剧应该下载到哪里，好吧，下载到 E盘的abc文件夹里面吧，那么 E：\abc\ 就是 `<path>` 标签的内容啦 

 5. 最后我们完善一下这个追剧信息

        <media>
	        <name>卡特探员</name>
	        <sitechecker>ygdy</sitechecker>
	    	<linkdata><![CDATA[20150107/47075]]></linkdata>
	    	<path><![CDATA[E:\TV\]]></path>
	    </media>

把上面这部分代码添加到 tvseries.xml 文件中就可以了

如何定义资源网站（sites.xml）
-------------------
首先我们先看一下这个文件的结构

    <?xml version="1.0" encoding="UTF-8" standalone="yes"?>
    <NimitzDEV>
    	<ygdy>
    		<link_prefix><![CDATA[http://www.ygdy8.net/html/tv/oumeitv/]]></link_prefix>
    		<link_suffix><![CDATA[.html]]></link_suffix>
    		<scanRegularExp><![CDATA[ftp://[^\x22 >]+]]></scanRegularExp>
    		<scanSpliter><![CDATA[/]]></scanSpliter>
    		<fileNamePos>4</fileNamePos>
    		<requireLogin>False</requireLogin>
    		<loginLink><![CDATA[]]></loginLink>
    		<loginFail_TruePart><![CDATA[]]></loginFail_TruePart>
    		<loginFail_FalsePart><![CDATA[]]></loginFail_FalsePart>
    		<loginOK_TruePart><![CDATA[]]></loginOK_TruePart>
    	</ygdy>
    </NimitzDEV>

每一组大标签的名字都是自己定的，例如阳光电影我可以写 `<ygdy>` 标签就可以了
当你在 tvseries.xml 文件中检测的资源是来自阳光电影的话，那么这个追剧的 `<sitechecker>` 里面就应该写 ygdy

那么，里面的每个小标签又代表了什么呢？

`<link_prefix>`  表示，剧集连接的前缀

 `<link_suffix>` 表示，剧集连接的后缀

> 前缀和后缀的认定：这里以阳光电影的剧集页面为例子
> 
> 我们先打开两个页面对比一下
> 
> http://www.ygdy8.net/html/tv/oumeitv/20150107/47075.html
>
> http://www.ygdy8.net/html/tv/oumeitv/20141210/46850.html
> 
> 可以发现，加粗的部分是不同的，其他部分是相同的，那么以不同的部分为准，它的前面就是前缀，后面就是后缀，把它们分别放入 `<link_prefix>` 和 `<link_suffix>` 两个标签中
> 
> 所以，当我们在 tvseries.xml 中的追剧来自这个地方的时候， `<sitechecker>` 选这个，`<linkdata>` 就是不同的部分
> 
> 程序运行的时候就会把这三部分组合起来形成一个正确的页面



 `<scanRegularExp> ` 表示，扫描的正则表达式
> 通过正则表达式，选取页面上正确的下载链接
> 
> 实例中的网站都是 ftp 的链接开头，那么正则表达式就为 `ftp://[^\x22 >` 你可以直接套用，如果是ed2k的话就改为 ed2k 就行
> 
> 你也可以自己学习
> [正则表达式教程](http://www.w3cschool.cc/regexp/regexp-tutorial.html "正则表达式教程")

 `<scanSpliter> ` 表示，下载链接的分离符号
 `<fileNamePos> ` 表示，文件名在连接中的位置
> 为了使下载的文件文件名正确，我们需要从下载链接中提取相应的文件名
> 
> 举例子，我们发现网站的下载链接都是这样的
> 
> `ftp://dygod2:dygod2@y009.dygod.org:2014/超感警探第七季/[阳光电影www.ygdy8.com]超感警探第七季第01集[中英双字].mkv`
> 
> 我们可以发现，文件名在连接的最后一部分，并且连接都用一个 / 斜杠分开连接的每一个部分
> 
> 所以 / 斜杠就是下载链接的分离符号，从左往右数，文件名位于第**5**个，那么文件名的位置就为 **5-1 = 4** ，第**4**个
> 

 `<requireLogin> ` 表示，网站是否需要登录，目前版本请填写 `False`

----------

以下的功能暂未开启，敬请期待更新

 `<loginLink> `

 `<loginFail_TruePart> `

 `<loginFail_FalsePart> `

 `<loginOK_TruePart> `


----------
> Powered by NimitzDEV
> 
> [![新浪微博](http://nimitzdev.org/social/social_weibo.png)](http://weibo.com/2648108184)
> [![Google Plus](http://nimitzdev.org/social/social_googleplus.png)](https://plus.google.com/106518320171687145550/posts)
> [![推特](http://nimitzdev.org/social/social_twitter.png)](https://twitter.com/Nimitz5)
> [![Facebook](http://nimitzdev.org/social/social_facebook.png)](https://www.facebook.com/nimitzdev)
