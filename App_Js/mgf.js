<!----------EFEITO TITULO--------------->
<!--
if (document.all||document.getElementById) 
{
   newTitle=document.title
   document.title="";
   ieat=-1;
}

function animTitle() 
{
   if (document.all||document.getElementById) 
   {
       if (ieat<newTitle.length) 
       {
       ieat++;
       document.title=newTitle.substring(0, ieat+1);
       }
       else 
       {
       clearInterval(animateTitle)
       }
    }
}
animateTitle = setInterval('animTitle()', 50);
   
function mover_xy(n) {
if (self.moveBy) {
for (i = 50; i > 0; i--) {
for (j = n; j > 0; j--) {
self.moveBy(0,i);
self.moveBy(i,0);
self.moveBy(0,-i);
self.moveBy(-i,0);
}
}
}
}

function mover_x(n) {
if (self.moveBy) {
for (i = 50; i > 0; i--) {
for (j = n; j > 0; j--) {
self.moveBy(i,0);
self.moveBy(-i,0);
}
}
}
}

function mover_y(n) {
if (self.moveBy) {
for (i = 10; i > 0; i--) {
for (j = n; j > 0; j--) {
self.moveBy(0,i);
self.moveBy(0,-i);
}
}
}
}


//-->
