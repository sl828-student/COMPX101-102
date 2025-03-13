.text
.global main
main:

	jal readswitches
	#bitshift
	srli $3, $1, 8 
	#bitmask
	andi $4, $1, 255
	jal compare
	
compare:
	slt $5, $3, $4
	bnez $5, less
	beqz $5, greater
	
less:
	subui $sp, $sp, 1
	sw $4, 0($sp)
	
	jal writessd
	lw $4, 0($sp)
	addui $sp, $sp, 1
	jal main
greater:
	subui $sp, $sp, 1
	sw $3, 0($sp)
	jal writessd
	lw $3, 0($sp)
	addui $sp, $sp, 1
	jal main

