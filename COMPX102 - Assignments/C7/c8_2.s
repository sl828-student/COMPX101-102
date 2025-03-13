.text 
.global main
main:
	#Call readswitches, that puts the switch values in $1
	jal readswitches
	#Push $1 contents onto stack
	subui $sp, $sp, 1
	sw $1, 0($sp)
	
	jal writessd 
	#Pop off stack
	lw $1, 0($sp)
	addui $sp, $sp, 1
	#Jump back to main to again read and display switches
	jal main