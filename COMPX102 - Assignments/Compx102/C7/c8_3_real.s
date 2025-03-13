.text
.global main
main:
	#read in switches value
	jal readswitches
	#bitshift the value, save in reg 3
	srli $3, $1, 8 
	#bitmask the value, save in reg 4
	andi $4, $1, 255
	#jump to compare subroutine
	jal compare
	
compare:
	#if reg 3 less than reg 4 save 1 to reg 5, else 0 to reg 5
	slt $5, $3, $4
	#if reg 5 not equal 0, branch to less
	bnez $5, less
	#if reg 5 equal to 0, branch to greater
	beqz $5, greater
	
less:
	#push reg 4 to stack
	subui $sp, $sp, 1
	sw $4, 0($sp)
	#Jump to writessd
	jal writessd
	#pop reg 4 from stack
	lw $4, 0($sp)
	addui $sp, $sp, 1
	#jump to main
	jal main
greater:
	#push reg 3 to stack 
	subui $sp, $sp, 1
	sw $3, 0($sp)
	#jump to writessd
	jal writessd
	#pop reg 3 off stack
	lw $3, 0($sp)
	addui $sp, $sp, 1
	#jump to main
	jal main

