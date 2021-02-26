### 添加超时
<ul>
    <li>调用Join的时候,可以设置一个超时,用毫秒或者Timespace都可以</li>
    <ul>
        <li>如果返回True,那就是线程结束了</li>
        <li>如果返回false,那就是超时了</li>
    </ul>
    <li>Thread.Sleep()方法会暂停当前的线程,并等一段时间</li>
</ul>

<ul>
    <li>Thread.Sleep(0)这样调用会导致线程本身立即放弃本身当前的时间片,自动将CPU移交给其它线程</li>
    <li>Thread.Yield()做同样的事情,但是它智慧把执行交给同一处理器上的其它线程</li>
    <li>当等待Sleep或者Join的时候,线程处于阻塞的状态</li>
</ul>

Sleep(0)或Yield有时在高级性能调试的生产代码中很有用。它也是一个很好的诊断工具,有助于发现线程安全问题:<br/>
如果在代码中的任何地方插入Thread.Yield()就破坏了程序,那么程序几乎肯定有bug