$(
    function () {
        //alert('Hello')
        const sounds = $('audio')
        const pads = $('.pads div')
        const visual = $('.visual')
        const title = $('.title')
        const colors = ['red', 'orange', 'yellow', 'green', 'skyblue', 'slateblue']

        sounds.each(function(index,soundFile)
        {
            soundFile.onended = function(){
                visual.text('')
                title.text('')
            }
        })
        pads.each(function(index,pad){
            $(pad).on('click',function(){
                sounds.each(function(index, soundFile){
                    soundFile.pause()
                })
                //내가 클릭한 부분의 사운드
                //ex)가장 첫번째거 클릭하면 1.mp3 재생
                if(sounds[index]){
                    sounds[index].currentTime = 0
                    sounds[index].play()
                    const strArray = sounds[index].src.split("sound/")
                    title.text(strArray[1])
                }
                createBubbles(index)
            });

        })

        const createBubbles = function(index)
        {
            visual.text('')
            const bubble = $('<div><dir/>')
            visual.append(bubble)
            bubble.css('background',colors[index]).
            css('top','300px').
            css('animation','animation 2000ms linear infinite both')
        }
    }
)